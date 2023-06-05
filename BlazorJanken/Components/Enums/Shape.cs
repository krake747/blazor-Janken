namespace BlazorJanken.Components.Enums;

public enum Shape
{
    Rock,
    Paper,
    Scissors
}

public static class ShapeExtensions
{
    public static string ToEmoji(this Shape shape)
    {
        return shape switch 
        {
            Shape.Rock => "✊",
            Shape.Paper => "✋",
            Shape.Scissors => "✌️",
            _ => string.Empty
        };
    }
}