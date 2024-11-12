namespace Y01;

public struct Vector2D(double x, double y)
{
    public double X { get; } = x;
    public double Y { get; } = y;

    public double Magnitude() => Math.Sqrt(X * X + Y * Y);

    public Vector2D ToUnitVector()
    {
        double length = Magnitude();

        if (length == 0)
            throw new InvalidOperationException("Zero-length vector cannot be normalized.");

        return new Vector2D(X / length, Y / length);
    }

    public double Curvature(Vector2D other)
    {
        double dotProduct = X * other.X + Y * other.Y;
        double magnitudeProduct = Magnitude() * other.Magnitude();
        double angle = Math.Acos(dotProduct / magnitudeProduct);

        return angle * (180 / Math.PI);
    }

    public override string ToString() => $"({X}, {Y})";
}
