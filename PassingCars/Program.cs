//Solution: https://app.codility.com/demo/results/trainingGN2JBP-BD5/
//Detected time complexity: O(N)
//I saw that every time a west car pass the number of routes increase by the quantity of east cars

int[] Array = { 0, 1, 0, 1, 1, 0, 1, 0, 1 };
Console.WriteLine(Solution.solution(Array));

class Solution
{
    public static int solution(int[] A)
    {
        int east = 0;
        int west = 0;
        int result = 0;


        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == 0)
            {
                east++;
            }
            else
            {
                west++;
                result = result + east;
                if(result > 1000000000)
                    return -1;
            }
        }
        return result;
    }
}