namespace Ball.Common;

public class RandomBall : Ball
{
    public RandomBall(GameForm gameForm) : base(gameForm)
    {
        positionX = random.Next(gameForm.ClientSize.Width);
        positionY = random.Next(gameForm.ClientSize.Height);
    }
}
