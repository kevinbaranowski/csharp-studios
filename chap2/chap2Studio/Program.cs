using chap2Studio;

double radius = 0.0;
while (radius <= 0) {
    Console.WriteLine("Enter a radius: ");
    string? strRadius = Console.ReadLine();
    try {
        if (strRadius != null) {
            radius = double.Parse(strRadius);
        }
    } catch (Exception) {
        Console.WriteLine("Radius must be a number and can not be empty! Please try again.");
    }
}    
double circumference = Circle.Circumference(radius);
Console.WriteLine("The area of a circle with a radius of " + radius + " is: " + Circle.Area(radius));
Console.WriteLine("Additionally, the diameter of the circle is " + Circle.Diameter(radius) + " and the circumference is " + circumference);
Console.WriteLine("What is the gas mileage of your car?");
string? strMpg = Console.ReadLine();
if (!String.IsNullOrEmpty(strMpg)) {
    double mpg = double.Parse(strMpg);
    Console.WriteLine("You would use " + Circle.GallonsUsed(radius, mpg) + " gallons of gas to travel " + circumference + " miles around the circle.");
}