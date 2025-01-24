using System.Drawing;
using System.Windows.Forms;
namespace Balls.Common;

public class MoveBall : RandomBall
{
    public MoveBall(Form gameForm) : base(gameForm)
    {
        var vSign = (random.NextDouble() > 0.5) ? 1 : -1;
        vx = (float)(random.NextDouble() + 0.01) * (5 * vSign);
        vy = (float)(random.NextDouble() + 0.01) * (5 * vSign);
        Radius = random.Next(10, 40);
    }

    public MoveBall(Form gameForm, Brush brush) : base(gameForm, brush)
    {
        var vSign = (random.NextDouble() > 0.5) ? 1 : -1;
        vx = (float)(random.NextDouble() + 0.01) * (5 * vSign);
        vy = (float)(random.NextDouble() + 0.01) * (5 * vSign);
        Radius = 15;
    }
}
