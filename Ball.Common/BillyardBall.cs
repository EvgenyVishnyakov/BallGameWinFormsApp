using System;
using System.Windows.Forms;

namespace Balls.Common;

public class BillyardBall : MoveBall
{
    public event EventHandler<HitEventArgs> OnHited;
    public BillyardBall(Form form) : base(form)
    {        
    }
    protected override void Go()
    {
        base.Go();
        if (brush == GetBrush())
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
