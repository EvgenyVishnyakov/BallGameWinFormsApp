using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common;

public class DiffusionBall : MoveBall
{
    Brush brushRed;
    Brush brushGreen;

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
        if (brush == Brushes.OrangeRed)
        {
            if (centerX <= LeftSide())
            {
                centerX = LeftSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                centerY = TopSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                centerY = DownSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Bottom));
            }
        }
        if (brush == Brushes.GreenYellow)
        {
            if (centerX <= LeftSide())
            {
                centerX = LeftSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                centerY = TopSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                centerY = DownSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Bottom));
            }
        }
    }
}
