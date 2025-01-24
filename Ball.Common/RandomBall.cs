using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common;

public class RandomBall : Ball
{
    public RandomBall(Form gameForm) : base(gameForm)
    {
        CenterX = random.Next(LeftSide(), RightSide());
        CenterY = random.Next(TopSide(), DownSide());
    }
    public RandomBall(Form gameForm, Brush brush) : base(gameForm,brush)
    {
        CenterY = random.Next(TopSide(), DownSide());
    }
}
