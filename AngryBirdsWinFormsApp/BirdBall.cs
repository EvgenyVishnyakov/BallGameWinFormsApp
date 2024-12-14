using Balls.Common;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp;

public class BirdBall : MoveBall
{
    private float g_vy = 0.67f;
    private float breakBall = 0.28f; 
    
    public BirdBall(Form mainForm) : base(mainForm)
    {
        radius = 20;
        brush = Brushes.Blue;
        centerX = LeftSide();
        centerY = DownSide();        
    }
    protected override void Go()
    {
        base.Go();        
        DriveBird();
        vy += g_vy;
    }
    private void DriveBird()
    {
        if (centerY >= DownSide())
        {
            vy = -vy;
            centerY = DownSide();
            vx *= breakBall;
            vy *= breakBall;            
        }
        if (vx < 0.1 && vy < 0.1)
        {
            Clear();
            Stop();            
        }
    }
    public void SetVelocity(int x,int y)
    {
        vx = (x - centerX) / 10;
        vy = (y - centerY) / 10;
    }      
    public bool OutSide()
    {
        return centerX > RightSide();
    }
}
