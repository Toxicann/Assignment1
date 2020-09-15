using System;

class Program
{
    static void Main(string[] args)
    {
        string ifcont;

        do
        {
            Console.WriteLine("Choose:\n 1. Simple Interest\n 2. Compound Interest\n 3. Area Of Circle\n 4. Volume of Sphere\n 5. BMI calculation\n 6. Gravitational Force\n 7. MassEnergy Equivalence");
            int switch_on = Int16.Parse(Console.ReadLine());
            switch (switch_on)
            {
                case 1:
                    SimpleInterest();
                    break;

                case 2:
                    CompoundInterest();
                    break;

                case 3:
                    AreaOCircle();
                    break;

                case 4:
                    VolOSphere();
                    break;

                case 5:
                    BmiCalc();
                    break;

                case 6:
                    GravitationalForce();
                    break;

                case 7:
                    MassEngergy();
                    break;

                default:
                    Console.WriteLine("Invalid argument");
                    break;
            }
            Console.WriteLine("Continue..? Y..?");
            ifcont = Console.ReadLine();
            ifcont = ifcont.ToUpper();

        }while(ifcont == "Y");

    }


    static void SimpleInterest()
    {
        double principle, time, rate, interest;

        Console.WriteLine("Enter Principle, Time, Rate resp:");
        principle = Convert.ToDouble(Console.ReadLine());
        time = Convert.ToDouble(Console.ReadLine());
        rate = Convert.ToDouble(Console.ReadLine());

        interest = (principle * rate * time) / 100.0;
        interest = Math.Round(interest, 2);
        Console.WriteLine("Simple Interest is: {0} ", interest);
    }

    static void CompoundInterest()
    {
        double principle, time, rate, interest, compound;

        Console.WriteLine("Enter Principle, Time, Rate resp:");
        principle = Convert.ToDouble(Console.ReadLine());
        time = Convert.ToDouble(Console.ReadLine());
        rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the no. of compounding periond per unit time: ");
        Console.WriteLine("For Ex. For Annually- 1, for monthly -12, for daily-365 and so on ");
        compound = Convert.ToDouble(Console.ReadLine());

        interest = (principle * Math.Pow((1 + (rate / (compound * 100))), (compound * time)));
        interest = Math.Round(interest, 2);
        Console.WriteLine("Compound Interest is: {0} ", interest);
    }

    static void AreaOCircle()
    {
        Console.WriteLine("Enter Radius ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        area = Math.Round(area, 3);
        Console.WriteLine("Area of Circle is: {0} ", area);
    }

    static void VolOSphere()
    {
        Console.WriteLine("Enter Radius ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        volume = Math.Round(volume, 3);
        Console.WriteLine("Volume of Sphere is: {0} ", volume);
    }

    static void BmiCalc()
    {
        Console.WriteLine("Enter your weight in kg & height in cm: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());

        height = height / 100.0;
        double bmi = weight / Math.Pow(height, 2);
        bmi = Math.Round(bmi, 2);

        Console.WriteLine("BMI is {0}", bmi);
    }

    static void BillPPerson()
    {
        Console.WriteLine("Enter The Bill Amount and the no. of persons to split the bill with: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        double people = Convert.ToDouble(Console.ReadLine());

        double billpperson = amount / people;

        Console.WriteLine("Bill Per Person is: {0}", billpperson);
    }

    static void GravitationalForce()
    {
        double kGravitationalForceConst = 6.674 * Math.Pow(10, -11);
        Console.WriteLine("Enter the value of Mass1, Mass2 in kg & distance betn these masses in m");
        double mass1 = Convert.ToDouble(Console.ReadLine());
        double mass2 = Convert.ToDouble(Console.ReadLine());
        double distance = Convert.ToDouble(Console.ReadLine());

        double Force = (kGravitationalForceConst * mass1 * mass2) / Math.Pow(distance, 2);

        Console.WriteLine("G Force is: {0}", Force);


    }

    static void MassEngergy()
    {
        double speedoLight = 3 * Math.Pow(10, 8);
        Console.WriteLine("Enter the value of Mass in kg");
        double mass = Convert.ToDouble(Console.ReadLine());
        double energy = mass * speedoLight * speedoLight;

        Console.WriteLine("Energy E is: {0}", energy);
    }
}