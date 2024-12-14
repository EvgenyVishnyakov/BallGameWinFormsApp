using System.Drawing;
using System.Runtime.CompilerServices;

namespace Ball.Common;
public class Ball
{
    protected Rectangle rectangle = new Rectangle();
    public Random random = new Random();
    private GameForm game = new GameForm();
    
    protected int vx = 5;
    protected int vy = -5;

    public int positionX;
    public int positionY;
    public int size = 70;

    public Ball()
    {
        this.game = game;
    }
    public void Show()
    {
        var graphiscs = game.CreateGraphics();
        Brush brush = new SolidBrush(Color.FromArgb(random.Next(105, 255), random.Next(90, 255), random.Next(55, 255)));
        rectangle = new Rectangle(positionX, positionY, size, size);
        graphiscs.FillEllipse(brush, rectangle);
    }
    public bool Contains(int x, int y)
    {
        var radius = size / 2;
        var centerX = positionX + radius;
        var centerY = positionY + radius;
        return (centerX - x) * (centerX - x) + (centerY - y) * (centerX - y) <= radius * radius;
    }
    private void Go()
    {
        positionX += vx;
        positionY += vy;
    }
    public void Clear()
    {
        var graphiscs = game.CreateGraphics();
        var brush = Brushes.LightGray;
        rectangle = new Rectangle(positionX, positionY, size, size);
        graphiscs.FillEllipse(brush, rectangle);
    }
    public void MoveBall()
    {
        Clear();
        Go();
        Show();
    }
}
