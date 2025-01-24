using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Balls.Common;

namespace DiffusionWinFormsApp;

public partial class MainForm : Form
{
    Timer timer = new Timer();

    List<DiffusionBall> balls = new();

    private Random _random = new Random();
    private int _amountBall = 20;

    public MainForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        StopButton.Enabled = false;
        timer = new Timer();
        timer.Interval = 25;
        timer.Tick += Timer_Tick; ;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        var graphics = CreateGraphics();
        var pen = new Pen(Color.Red, 2);

        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        graphics.DrawLine(pen, Width / 2, 0, Width / 2, Height);

        EndOfShuffle();
    }

    private void MoveBallButton_Click(object sender, EventArgs e)
    {
        ContinueButton.Enabled = false;
        StopButton.Enabled = true;

        for (int i = 0; i < _amountBall; i++)
        {
            ChoosePlaceAndColorBall(i);
        }

        MoveBallButton.Enabled = false;
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        StopButton.Enabled = false;
        ContinueButton.Enabled = true;
        MoveBallButton.Enabled = false;

        PauseGame();
    }

    private void PauseGame()
    {
        foreach (var ball in balls)
        {
            ball.Stop();
        }
    }

    private void ContinueButton_Click(object sender, EventArgs e)
    {
        StopButton.Enabled = true;
        ContinueButton.Enabled = false;
        BallStart();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void ChooseLeft()
    {
        var brushRed = Brushes.OrangeRed;
        var billyardRed = new DiffusionBall(this, brushRed);
        billyardRed.OnHited += BillyardRed_OnHited;
        billyardRed.Start();
        billyardRed.CenterX = _random.Next(billyardRed.LeftSide(), ClientSize.Width / 2 - billyardRed.Radius);
        balls.Add(billyardRed);
    }

    private void ChooseRight()
    {
        var brushGreen = Brushes.GreenYellow;
        var billyardGreen = new DiffusionBall(this, brushGreen);
        billyardGreen.OnHited += BallsGreen_OnHited;
        billyardGreen.Start();
        billyardGreen.CenterX = _random.Next(ClientSize.Width / 2 - billyardGreen.Radius, billyardGreen.RightSide());
        balls.Add(billyardGreen);
    }

    private void ChoosePlaceAndColorBall(int i)
    {
        if (i % 2 == 0)
        {
            ChooseLeft();
        }
        else
        {
            ChooseRight();
        }
    }

    private void BillyardRed_OnHited(object? sender, Balls.Common.HitEventArgs e)
    {
        switch (e.Side)
        {
            case Side.Left: redleftLabel.Text = (Convert.ToInt32(redleftLabel.Text) + 1).ToString(); break;
            case Side.Right: redRightLabel.Text = (Convert.ToInt32(redRightLabel.Text) + 1).ToString(); break;
            case Side.Top: redTopLabel.Text = (Convert.ToInt32(redTopLabel.Text) + 1).ToString(); break;
            case Side.Bottom: redDownLabel.Text = (Convert.ToInt32(redDownLabel.Text) + 1).ToString(); break;
        }
    }

    private void BallsGreen_OnHited(object? sender, Balls.Common.HitEventArgs e)
    {
        switch (e.Side)
        {
            case Side.Left: greenLeftLabel.Text = (Convert.ToInt32(greenLeftLabel.Text) + 1).ToString(); break;
            case Side.Right: greenRightLabel.Text = (Convert.ToInt32(greenRightLabel.Text) + 1).ToString(); break;
            case Side.Top: greenTopLabel.Text = (Convert.ToInt32(greenTopLabel.Text) + 1).ToString(); break;
            case Side.Bottom: greenBottomLabel.Text = (Convert.ToInt32(greenBottomLabel.Text) + 1).ToString(); break;
        }
    }

    private void EndOfShuffle()
    {
        var redLeftCount = 0;
        var redRightCount = 0;
        var greenLeftCount = 0;
        var greenRightCount = 0;
        foreach (var ball in balls)
        {
            if (ball.LeftOfCenter())
            {
                if (ball.GetBrush() == Brushes.OrangeRed)
                {
                    redLeftCount++;
                }
                else
                {
                    greenLeftCount++;
                }
            }
            if (ball.RightOfCenter())
            {
                if (ball.GetBrush() == Brushes.GreenYellow)
                {
                    redRightCount++;
                }
                else
                {
                    greenRightCount++;
                }
            }
        }

        if (redLeftCount == greenLeftCount && redRightCount == greenRightCount
                && redLeftCount + greenLeftCount + redRightCount + greenRightCount == _amountBall)
        {
            foreach (var ball in balls)
            {
                ball.Stop();
            }
        }
    }

    private void BallStart()
    {
        for (int i = 0; i < _amountBall; i++)
        {
            balls[i].Start();
        }
    }
}


