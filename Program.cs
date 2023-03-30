using System;
namespace OfficersProject;
class Program
{
    static void Main(string[] args)
    {
        Officer officer1 = new Officer("Raimonds", "Burts", 1, "Riga", 3);
        Officer officer2 = new Officer("Toms", "Berzins", 2, "Riga", 20);
        Officer officer3 = new Officer("Anna", "Liepa", 3, "Riga", 54);
        Officer officer4 = null;

        List<Officer> distric99 = new List<Officer>();

        distric99.Add(officer1);
        distric99.Add(officer2);
        distric99.Add(officer3);

        int count = 0;
        foreach(Officer item in distric99)
        {
            // Console.WriteLine(item.ToString());
            if (item.CalculateLevel(item.CrimeSolved) == 1)
            {
                Console.WriteLine(item.ToString());
                count++;
            }
        }
        Console.WriteLine($"Officers are with level 1 count is {count}");

        string s1 = "Oficers name";
        string s2 = null;
        string s3 = "";

        bool checkS1 = string.IsNullOrEmpty(s1);
        bool checkS2 = string.IsNullOrEmpty(s2);
        bool checkS3 = string.IsNullOrEmpty(s3);

        Console.WriteLine("Check s1 " + checkS1);
        Console.WriteLine("Check s2 " + checkS2);
        Console.WriteLine("Check s3 " + checkS3);

        if (s2 == null)
        {
            Console.WriteLine("S2 is null");
        }
        else
        {
            Console.WriteLine("S2 is not null");
        }

        Console.WriteLine("Enter text: ");

        string inputText = "";
        bool checkInoutText = true;

        //Console.WriteLine(checkInoutText);
        //while(checkInoutText)
        //{
        //    Console.WriteLine("Please enter text: ");
        //    inputText = Console.ReadLine();
        //    checkInoutText = string.IsNullOrEmpty(inputText);
        //}

        Console.WriteLine($"Text what was typed: {inputText}");

        Car car = new Car("BMW");
        Console.WriteLine("" + car.Name);
        car.Name = "Audi";
        Console.WriteLine($"new car {car.Name}" );
        
        Car carNew = null;

        if (carNew == null)
        {
            carNew = new Car("Seat");
        }
        else
        {
            Console.WriteLine("Car obj ready");
        }

        Console.WriteLine(carNew.Name);



        //Console.WriteLine($"Crime solved:  {officer2.CrimeSolved}");
        //Console.WriteLine($"Name {officer2.Name} Level of officer: {officer2.CalculateLevel(officer2.CrimeSolved)}");
    }
}
