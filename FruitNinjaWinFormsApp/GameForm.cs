using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp;

public partial class GameForm : Form
{
    public StepTime StepTime { get; set; }

    private int gameTimes = 15;
    private int totalTime = 0;
    private int leftTimeSeconds = 0;
    private int catchedTotalBalls;
    private int minCountBall = 2;
    private int maxCountBall = 5;

    private int _slowBallTime { get; set; }
    private int _baseTime { get; set; }

    private Random _random = new Random();
    private List<FruitBall> _fruitBalls = new();

    public GameForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        _baseTime = FruitTimer.Interval;
        StepTime = new StepTime(_baseTime);
    }

    private void FruitTimer_Tick(object sender, EventArgs e)
    {
        totalTime += FruitTimer.Interval;
        if (totalTime % 1500 == 0)
        {
            ThrowAwayBall();
            leftTimeSeconds++;
        }

        if (leftTimeSeconds >= gameTimes)
        {
            StopGame();
            MessageBox.Show($"Игра окончена! Количество пойманных шариков = {catchedTotalBalls}");
            Application.Exit();
        }

        if (_slowBallTime > 0)
        {
            countTimerLabel.Visible = true;
            _slowBallTime -= FruitTimer.Interval;
            PrintTimer();
        }
        else
        {
            countTimerLabel.Visible = false;
            StepTime.Interval = _baseTime;
        }
    }

    private void PrintTimer()
    {
        var sec = _slowBallTime / 1000;
        var millisec = _slowBallTime % 1000;
        countTimerLabel.Text = $"До окончания замедления времени: {sec} сек. {millisec} милисек.";
    }

    private void GameForm_MouseMove(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < _fruitBalls.Count; i++)
        {
            if (IsCatched(e, i))
            {
                CutBall(i);
                if (_fruitBalls[i].IsBomb())
                {
                    StopGame();
                    MessageBox.Show($"Вы взорвали бомбу), игра закончена! Количество пойманных шариков = {catchedTotalBalls}");
                    Application.Exit();
                }

                if (_fruitBalls[i].IsBanana())
                {
                    _slowBallTime = 3 * 1000;
                    StepTime.Interval = _baseTime * 2;
                }
                else
                {
                    catchedTotalBalls++;
                }
            }

            CountBallLabel.Text = catchedTotalBalls.ToString();
        }
    }

    private void StopGame()
    {
        FruitTimer.Stop();
        foreach (var ball in _fruitBalls)
        {
            ball.Stop();
            ball.Clear();
        }
    }

    private bool IsCatched(MouseEventArgs e, int i)
    {
        return _fruitBalls[i].IsMoveBallable() && _fruitBalls[i].Contains(e.X, e.Y);
    }

    private void CutBall(int i)
    {
        _fruitBalls[i].Clear();
        _fruitBalls[i].Stop();
    }

    private void ThrowAwayBall()
    {
        var salutCountBall = _random.Next(minCountBall, maxCountBall);
        for (int i = 0; i < salutCountBall; i++)
        {
            var salut = new FruitBall(this);
            salut.Start();
            _fruitBalls.Add(salut);
        }
    }

    private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}


