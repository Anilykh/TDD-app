<<<<<<< HEAD
public class Converter
{
    public double InchesToMm(double inches)
    {
        return inches * 15.4;
    }


    public double InchesToCm(double inches)
    {
        return inches * 1.54;
    }

    public double InchesToM(double inches)
    {
        return inches * 0.154;
    }

    public double Convert(double inches, string outputUnit)
    {
        switch (outputUnit)
        {
            case "-mm":
                return InchesToMm(inches);
            case "-cm":
                return InchesToCm(inches);
            case "-m":
                return InchesToM(inches);
            default:
                throw new ArgumentException("Invalid output unit. Please enter one of the following: 'mm','cm', 'm' ");
        }
    }
    Converter converter = new Converter();
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length !=2)
            {
                Console.WriteLine("Handling: convert <inches> <output_unit");
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }
        }
        
    }
}

double Millimeters = converter.InchesToMm(inches);
double Centimeters = converter.InchesToCm(inches);
double Meters = converter.InchesToM(inches);

Console.WriteLine($"{inches} inches is equal to:");
Console.WriteLine($"{Millimeters} millimeters");
Console.WriteLine($"{Centimeters} centimeters");
Console.WriteLine($"{Meters} meters");


=======
public class Converter
{
    public double InchesToMm(double inches)
    {
        return inches * 15.4;
    }


    public double InchesToCm(double inches)
    {
        return inches * 1.54;
    }

    public double InchesToM(double inches)
    {
        return inches * 0.154;
    }

    public double Convert(double inches, string outputUnit)
    {
        switch (outputUnit)
        {
            case "-mm":
                return InchesToMm(inches);
            case "-cm":
                return InchesToCm(inches);
            case "-m":
                return InchesToM(inches);
            default:
                throw new ArgumentException("Invalid output unit. Please enter one of the following: 'mm','cm', 'm' ");
        }
    }
    Converter converter = new Converter();

    public class Program
    {
        public static void Main(string[] args)
        {
            if(args.Contains("-t"))
            {
                RunTests();
                return;
            }
            if (args.Length !=2)
            {
                Console.WriteLine("Handling: convert <inches> <output_unit");
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }
        }
        
    }
}


double Millimeters = converter.InchesToMm(inches);
double Centimeters = converter.InchesToCm(inches);
double Meters = converter.InchesToM(inches);

Console.WriteLine($"{inches} inches is equal to:");
Console.WriteLine($"{Millimeters} millimeters");
Console.WriteLine($"{Centimeters} centimeters");
Console.WriteLine($"{Meters} meters");


>>>>>>> 9035d6dd261c420662a8f77bf6640308f8e17801
