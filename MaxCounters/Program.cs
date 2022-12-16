//First solution: https://app.codility.com/demo/results/trainingNYY9ZB-2GP/
//Detected time complexity: didn't return 77% score

int[] Array = { 3, 4, 4, 6, 1, 4, 4 };
int[] resultSolution = Solution.solution(5, Array);
for(int i = 0; i < resultSolution.Length; i++)
{
    Console.Write(resultSolution[i] + ", ");
}
Console.WriteLine();


class Solution
{
    public static int[] solution(int N, int[] A)
    {
        var a = A;
        var counters = new int[N];
        var maxCounter = 0;
        var counterPosition = 0;
        for(var i = 0; i < a.Length; i++)
        {
            if(a[i] <= N)
            {
                counterPosition = a[i] - 1;
                counters[counterPosition]++;
                maxCounter = Math.Max(counters[counterPosition], maxCounter);
            }
            else if(a[i] > N)
            {
                for(int j = 0; j < counters.Length; j++)
                    counters[j] = Math.Max(counters[j], maxCounter);
            }
        }

        return counters;
    }
}
