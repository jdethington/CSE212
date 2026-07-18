using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("\nHello Sandbox World!\n");

        // Week 3 Interview questions
        var set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        var set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
        var set3 = set1.Intersect(set2).ToHashSet(); // This will result in {4, 5}
        var set4 = set1.Union(set2).ToHashSet();     // This will result in {1, 2, 3, 4, 5, 6, 7, 8}    
        Console.WriteLine("set1+set2: " + string.Join(", ", set1) + ", " + string.Join(", ", set2));
        Console.WriteLine($"Intersect: {string.Join(", ", set3)}");
        Console.WriteLine($"    Union: {string.Join(", ", set4)}");
        // An intersection of two sets contains items that are in both of the two sets.
        var setUnion = new HashSet<int>();
        var setIntersection = new HashSet<int>();
        // Union
        foreach (var x in set1)
        {
            if (!setUnion.Contains(x))
                setUnion.Add(x);
        }
        foreach (var x in set2)
        {
            if (!setUnion.Contains(x))
                setUnion.Add(x);
        }
        // Intersection
        // Iterate over the smaller set for better performance
        if (set2.Count < set1.Count)
        {
            (set1, set2) = (set2, set1); // Swap so setA is smaller
        }
            foreach (var u in set1)
            {
                if (set2.Contains(u))
                    setIntersection.Add(u);
            }

        // A union of two sets contains all items that are in either set.

        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Intersect: {string.Join(", ", setIntersection)}");
        Console.WriteLine($"    Union: {string.Join(", ", setUnion)}");
        Console.WriteLine();
    }
}