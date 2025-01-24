using System;
using System.Drawing;
using System.Windows.Forms;
using Balls.Common;

namespace FruitNinjaWinFormsApp;

public class FruitBall : Ball
{
    private float g = 0.021f;
    private StepTime _stepTime { get; set; }

    public FruitBall(GameForm gameForm) : base(gameForm)
    {
        GenerateStartPositionBall(gameForm);
        Radius = random.Next(20, 35);
        _stepTime = gameForm.StepTime;
        timer.Interval = _stepTime.Interval;
    }

    protected override void Timer_Tick(object sender, EventArgs e)
    {
        timer.Interval = _stepTime.Interval;
        base.Timer_Tick(sender, e);
    }

    private void GenerationSpeedVY()
    {
        vy = (float)random.NextDouble() * (-1) - 3;
    }

    public bool IsBanana()
    {
        return Brush == Brushes.Yellow;
    }

    public bool IsBomb()
    {
        return Brush == Brushes.Black;
    }

    private void GenerateStartPositionBall(Form gameForm)
    {
        GenerateCenterX(gameForm);
        GenerateCenterY();
        GenerateDirection(gameForm);
        GenerationSpeedVY();
    }

    private float GenerateDirection(Form gameForm)
    {
        return (CenterX == gameForm.ClientSize.Width / 8) ? vx = (float)random.NextDouble() * 2 + 5 : vx = (float)random.NextDouble() * -4 - 1;
    }

    private void GenerateCenterY()
    {
        CenterY = (float)DownSide() + 1;
    }

    private void GenerateCenterX(Form gameForm)
    {
        CenterX = random.Next(1, 3) == 1 ? gameForm.ClientSize.Width / 8 : gameForm.ClientSize.Width - gameForm.ClientSize.Width / 8;
    }

    protected override void Go()
    {
        base.Go();
        vy += g;
        if (CenterY < -Radius)
        {
            Stop();
        }
    }
}


