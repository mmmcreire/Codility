//Solution: https://app.codility.com/demo/results/trainingWV5BHN-PU4/
//Detected time complexity: O(B-A)

Console.WriteLine(Solution.solution(0, 2000000000, 1));

class Solution
{
    public static int solution(int A, int B, int K)
    {
        int result = 0;
        int size = B - A;

        for(int i = 0; i <= size; i++)
        {
            if((A + i) % K == 0)
                result++;
        }
        return result;
    }
}