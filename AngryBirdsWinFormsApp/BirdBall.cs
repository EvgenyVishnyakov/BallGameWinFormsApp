using System.Drawing;
using System.Windows.Forms;
using Balls.Common;

namespace AngryBirdsWinFormsApp;

public class BirdBall : MoveBall
{
    private float g_vy = 0.67f;
    private float _breakBall = 0.28f;

    public BirdBall(Form mainForm) : base(mainForm)
    {
        Radius = 20;
        Brush = Brushes.Blue;
        CenterX = LeftSide();
        CenterY = DownSide();
    }
    protected override void Go()
    {
        base.Go();
        DriveBird();
        vy += g_vy;
    }

    private void DriveBird()
    {
        if (CenterY >= DownSide())
        {
            vy = -vy;
            CenterY = DownSide();
            vx *= _breakBall;
            vy *= _breakBall;
        }
        if (vx < 0.1 && vy < 0.1)
        {
            Clear();
            Stop();
        }
    }

    public void SetVelocity(int x, int y)
    {
        vx = (x - CenterX) / 10;
        vy = (y - CenterY) / 10;
    }
    public bool OutSide()
    {
        return CenterX > RightSide();
    }
}
