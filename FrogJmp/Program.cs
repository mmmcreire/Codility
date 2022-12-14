Console.WriteLine(Solution.solution(3, 999111321, 7));

class Solution
{
    public static int solution(int X, int Y, int D)
    {
        //First solution: https://app.codility.com/demo/results/trainingTVJF54-7AM/
        //Detected time complexity: O(Y - X) (working but with low performance)
        //decimal distance = Y - X;
        //int jumps = 0;

        //while(distance > 0)
        //{
        //    jumps++;
        //    distance = distance - D;
        //}
        //return jumps;

        //Second solution: https://app.codility.com/demo/results/trainingDQPNWS-VTR/
        //Detected time complexity: O(1) :)
        decimal distance = Y - X;
        return Decimal.ToInt32(Math.Ceiling(distance / D));
    }
}
