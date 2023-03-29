namespace OfficersProject;
class Program
{
    static void Main(string[] args)
    {
        Officer officer1 = new Officer("Raimonds", "Burts", 1, "Riga", 3);
        Officer officer2 = new Officer("Toms", "Berzins", 2, "Riga", 20);
        Officer officer3 = new Officer("Anna", "Liepa", 3, "Riga", 54);

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


        //Console.WriteLine($"Crime solved:  {officer2.CrimeSolved}");
        //Console.WriteLine($"Name {officer2.Name} Level of officer: {officer2.CalculateLevel(officer2.CrimeSolved)}");
    }
}
