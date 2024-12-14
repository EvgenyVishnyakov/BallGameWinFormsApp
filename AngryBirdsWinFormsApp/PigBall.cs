using Balls.Common;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp;

public class PigBall : RandomBall
{    
    public PigBall(Form mainForm) : base(mainForm)
    {
        brush = Brushes.Pink;
        radius = 30;       
        GetPositionOnForm();        
    }
    private void GetPositionOnForm()
    {
        centerX = random.Next(LeftSide() * 5, RightSide());
        centerY = random.Next(TopSide() * 3 , DownSide());
    }    
}
