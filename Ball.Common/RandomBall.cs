using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common;

public class RandomBall : Ball
{
    public RandomBall(Form gameForm) : base(gameForm)
    {
        centerX = random.Next(LeftSide(), RightSide());
        centerY = random.Next(TopSide(), DownSide());
    }
    public RandomBall(Form gameForm, Brush brush) : base(gameForm,brush)
    {
        centerY = random.Next(TopSide(), DownSide());
    }
}
