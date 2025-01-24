using System;
using System.Windows.Forms;

namespace Balls.Common;

public class BillyardBall : MoveBall
{
    public event EventHandler<HitEventArgs> OnHited;
    private Form _form { get; set; }

    public BillyardBall(Form form) : base(form)
    {
        _form = form;
    }

    protected override void Go()
    {
        base.Go();
        if (Brush == GetBrush())
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
