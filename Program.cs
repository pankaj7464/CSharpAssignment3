namespace CsharpAssignment3
{

class Program
{
    static void Main(string[] args)
    {
        // Dictionary to store prime ministers and their years
        Dictionary<string, int> primeMinisters = new Dictionary<string, int>
        {
            { "Atal Bihari Vajpayee", 1998 },
            { "Narendra Modi", 2014 },
            { "Manmohan Singh", 2004 }
        };

        // Find the Prime Minister of 2004
        Console.WriteLine($"Prime Minister of 2004: {GetPrimeMinisterOfYear(primeMinisters, 2004)}");

        // Add the current prime minister
        AddCurrentPrimeMinister(primeMinisters, "Current Prime Minister");

        // Sort the dictionary by year
        var sortedPrimeMinisters = primeMinisters.OrderBy(kv => kv.Value);

        // Print the sorted dictionary
        Console.WriteLine("\nPrime Ministers sorted by year:");
        foreach (var kvp in sortedPrimeMinisters)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    static string GetPrimeMinisterOfYear(Dictionary<string, int> primeMinisters, int year)
    {
        foreach (var kvp in primeMinisters)
        {
            if (kvp.Value == year)
            {
                return kvp.Key;
            }
        }
        return "Prime Minister not found for the given year.";
    }

    static void AddCurrentPrimeMinister(Dictionary<string, int> primeMinisters, string name)
    {
        // Assume the current year is 2024
        int currentYear = 2024;
        primeMinisters.Add(name, currentYear);
    }
}

}