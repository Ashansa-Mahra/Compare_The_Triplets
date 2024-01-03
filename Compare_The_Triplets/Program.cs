class Result
{
    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        int[] alice = a.ToArray();
        int[] bob = b.ToArray();
        var points = new int[2];
        int bobPoints = 0; int alicePoints = 0;
        for (int i = 0; i < 3; i++)
        {
            if (bob[i] > alice[i])
            {
                bobPoints++;
            }
            if (alice[i] > bob[i])
            {
                alicePoints++;
            }
        }
        points[0] = alicePoints;
        points[1] = bobPoints;
        return points.ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.CompareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
    }
}
