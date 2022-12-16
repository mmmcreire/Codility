//First solution: https://app.codility.com/demo/results/trainingB99K82-R8B/
//Detected time complexity: O(N)

int[] Array = { 1, 1, 1, 2, 3, 4 };
Console.WriteLine(Solution.solution(Array));

class Solution
{
    public static int solution(int[] A)
    {
        HashSet<int> set = new HashSet<int>(A);
        if(set.Count != A.Length)
            return 0;

        if(set.Count == A.Max())
            return 1;
        return 0;
    }
}
