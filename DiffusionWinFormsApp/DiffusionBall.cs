using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common;

public class DiffusionBall : MoveBall
{
    //Brush brushRed;
    //Brush brushGreen;

    public event EventHandler<HitEventArgs> OnHited;

    public DiffusionBall(Form form, Brush brush) : base(form, brush)
    {
        timer.Interval = 25;
        timer.Tick += Timer_Tick1; ;
        timer.Start();
    }

    private void Timer_Tick1(object? sender, EventArgs e)
    {
        MoveBall();
    }

    protected override void Go()
    {
        base.Go();
        if (Brush == Brushes.OrangeRed)
        {
            if (CenterX <= LeftSide())
            {
                CenterX = LeftSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (CenterX >= RightSide())
            {
                CenterX = RightSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (CenterY <= TopSide())
            {
                CenterY = TopSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (CenterY >= DownSide())
            {
                CenterY = DownSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Bottom));
            }
        }

        if (Brush == Brushes.GreenYellow)
        {
            if (CenterX <= LeftSide())
            {
                CenterX = LeftSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (CenterX >= RightSide())
            {
                CenterX = RightSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (CenterY <= TopSide())
            {
                CenterY = TopSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (CenterY >= DownSide())
            {
                CenterY = DownSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Bottom));
            }
        }
    }
}
