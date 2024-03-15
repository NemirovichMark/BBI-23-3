using System;

struct Sportsman
{
    private string famile;
    private double bestResult;

    public Sportsman(string fam, double result)
    {
        famile = fam;
        bestResult = result;
    }

    public string Famile { get { return famile; } }
    public double BestResult { get { return bestResult; } }

    public void DisplayResult(int position)
    {
        Console.WriteLine("{0}. {1} - Best result: {2}", position, famile, bestResult);
    }

    public static void GnomeSort(Sportsman[] arr)
    {
        int n = arr.Length;
        int i = 0;
        int j = i + 1;
      
        while (i < n)
        {
            if (i == 0 || arr[i - 1].BestResult >= arr[i].BestResult)
            {
                i=j;
                j++;
            }
            else
            {
                Sportsman temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
                i--;
            }
        }
    }

    public static void SortAndDisplayResults(Sportsman[] arr)
    {
        GnomeSort(arr);

        Console.WriteLine("Results of the competition:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].DisplayResult(i + 1);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Sportsman[] sportsmen = new Sportsman[5];

        sportsmen[0] = new Sportsman("Ivanov", Math.Max(100, 120));
        sportsmen[1] = new Sportsman("Petrov", Math.Max(90, 75));
        sportsmen[2] = new Sportsman("Sidorov", Math.Max(105, 107));
        sportsmen[3] = new Sportsman("Bach", Math.Max(130, 110));
        sportsmen[4] = new Sportsman("Corsar", Math.Max(150, 90));

        Sportsman.SortAndDisplayResults(sportsmen);
    }
}


