namespace chap2Studio;
public class Circle
{
    public static double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
    public static double Diameter(double radius)
    {
        return radius * 2;
    }
    public static double Area(double radius)
    {
       return Math.PI * Math.Pow(radius, 2);
    }
    public static double GallonsUsed(double radius, double mpg)
    {
        double circumference = Circumference(radius);
        return circumference / mpg;
    }
}