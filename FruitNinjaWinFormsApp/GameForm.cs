using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp;

public partial class GameForm : Form
{
    Random random = new Random();
    List<FruitBall> fruitBalls = new List<FruitBall>();
    public StepTime stepTime;

    private int gameTimes = 15;
    private int totalTime = 0;
    private int leftTimeSeconds = 0;
    private int catchedTotalBalls;
    private int minCountBall = 2;
    private int maxCountBall = 5;
    private int slowBallTime;    
    private int baseTime;    

    public GameForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        baseTime = FruitTimer.Interval;
        stepTime = new StepTime(baseTime);
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
        
        if (slowBallTime > 0)
        {
            countTimerLabel.Visible = true;
            slowBallTime -= FruitTimer.Interval;
            PrintTimer();
        }
        else
        {
            countTimerLabel.Visible = false;
            stepTime.Interval = baseTime; 
        }       
    }    
    private void PrintTimer()
    {
        int sec = slowBallTime / 1000;
        int millisec = slowBallTime % 1000;
        countTimerLabel.Text = $"До окончания замедления времени: {sec} сек. {millisec} милисек.";
    }
    private void GameForm_MouseMove(object sender, MouseEventArgs e)
    {
        for (int i = 0; i < fruitBalls.Count; i++)
        {
            if (IsCatched(e, i))
            {
                CutBall(i);
                if (fruitBalls[i].IsBomb())
                {
                    StopGame();                    
                    MessageBox.Show($"Вы взорвали бомбу), игра закончена! Количество пойманных шариков = {catchedTotalBalls}");
                    Application.Exit();
                }
                if (fruitBalls[i].IsBanana())
                {
                    slowBallTime = 3 * 1000;
                    stepTime.Interval = baseTime * 2;
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
        foreach (var ball in fruitBalls)
        {
            ball.Stop();
            ball.Clear();   
        }
    }    
    private bool IsCatched(MouseEventArgs e, int i)
    {
        return fruitBalls[i].IsMoveBallable() && fruitBalls[i].Contains(e.X, e.Y);
    }
    private void CutBall(int i)
    {
        fruitBalls[i].Clear();
        fruitBalls[i].Stop();
    }   
    private void ThrowAwayBall()
    {
        int salutCountBall = random.Next(minCountBall, maxCountBall);
        for (int i = 0; i < salutCountBall; i++)
        {
            var salut = new FruitBall(this);
            salut.Start();
            fruitBalls.Add(salut);
        }
    }    
    private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
    private void GameForm_Load(object sender, EventArgs e)
    {
    }    
}


