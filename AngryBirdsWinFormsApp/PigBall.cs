using System.Drawing;
using System.Windows.Forms;
using Balls.Common;

namespace AngryBirdsWinFormsApp;

public class PigBall : RandomBall
{
    public PigBall(Form mainForm) : base(mainForm)
    {
        Brush = Brushes.Pink;
        Radius = 30;
        GetPositionOnForm();
    }

    private void GetPositionOnForm()
    {
        CenterX = random.Next(LeftSide() * 5, RightSide());
        CenterY = random.Next(TopSide() * 3, DownSide());
    }
}
