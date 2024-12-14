using System.Windows.Forms;

namespace SalutWinFormsApp;

public class VerticalBall : SalutBall
{    
    private float g = 0.21f;
    public VerticalBall(Form gameForm) : base(gameForm, gameForm.ClientSize.Width / 2, gameForm.ClientSize.Height)
    {        
        vx = 0;
        vy =  -10 ;             
    }   
    protected override void Go()
    {
        base.Go();
        vx = g;
        if (vy > 0)
        {
            Stop();
            Clear();                  
        }
    }    
}
   
