using System;
using System.Windows.Forms;
using Balls.Common;

namespace SalutWinFormsApp;

public class SalutBall : MoveBall
{
    private float g = 0.11f;

    public SalutBall(Form gameForm) : base(gameForm) { }

    public SalutBall(Form gameForm, int centerX, int centerY) : base(gameForm)
    {
        CenterX = centerX;
        CenterY = centerY;
        vy = -Math.Abs(vy);
        Radius = 20;
        timer.Interval = 60;
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    public SalutBall(Form gameForm, float centerX, float centerY) : this(gameForm)
    {
        CenterX = centerX;
        CenterY = centerY;
        vy = -Math.Abs(vy);
        Radius = 20;
        timer.Interval = 70;
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    protected override void Go()
    {
        base.Go();
        vy += g;
    }
}
