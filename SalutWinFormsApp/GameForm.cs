using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalutWinFormsApp;

public partial class GameForm : Form
{
    Timer timer = new Timer();

    private int minCountSalut = 15;
    private int maxCountSalut = 20;
    private float centerY;

    private Random _random = new Random();
    private List<VerticalBall> _verticalBalls = new();


    public GameForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        timer.Interval = 10;
        timer.Tick += Timer_Tick; ;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        StopVerticalBall();
    }

    private void GameForm_MouseDown(object sender, MouseEventArgs e)
    {
        var salutCount = StartSalut();
        CountSalut(e, salutCount);
    }

    private int StartSalut()
    {
        var salutCount = _random.Next(minCountSalut, maxCountSalut);
        return salutCount;
    }

    private void CountSalut(MouseEventArgs e, int salutCount)
    {
        for (int i = 0; i < salutCount; i++)
        {
            var salut = new SalutBall(this, e.X, e.Y);
            salut.Start();
        }
    }

    private async void SaluteTimer_Tick(object sender, EventArgs e)
    {
        var verticalBall = new VerticalBall(this);
        verticalBall.Start();
        _verticalBalls.Add(verticalBall);
        await Task.Delay(2000);
        MakeSalut();
    }

    public void StopVerticalBall()
    {
        foreach (var ball in _verticalBalls)
        {
            if (centerY < ClientSize.Height * 0.65)
            {
                ball.Clear();
            }
        }
    }

    private void MakeSalut()
    {
        var salutCountBall = StartSalut();
        SalutRandom(this, salutCountBall);
    }

    private void SalutRandom(object centerSalut, int salutCountBall)
    {
        float centerSalutX = GetKoordinate();
        float centerSalutY = ClientSize.Height * 0.35f;
        for (int i = 0; i < salutCountBall; i++)
        {
            var salut = new SalutBall(this, centerSalutX, centerSalutY);
            salut.Start();
        }
    }

    private int GetKoordinate()
    {
        return ClientSize.Width / 2;
    }
}
