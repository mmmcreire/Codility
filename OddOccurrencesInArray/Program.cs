int[] Array = { 44, 9, 3, 9, 3, 9, 7, 9, 7, 1, 1, 4, 4 };
Console.WriteLine(Solution.solution(Array));

class Solution
{
    public static int solution(int[] A)
    {

        //First solution: https://app.codility.com/demo/results/trainingDWP63M-MEG/
        //Detected time complexity: O(N * *2)
        //for(int i = 0; i < A.Length; i++)
        //{
        //    for(int j = 1; j < A.Length; j++)
        //    {
        //        if(A[i] == A[j] && i != j)
        //        {
        //            A[i] = -1;
        //            A[j] = -1;
        //            break;
        //        }
        //    }
        //}
        //for(int i = 0; i < A.Length; i++)
        //{
        //    if(A[i] > 0)
        //    {
        //        return A[i];
        //    }
        //}
        //return 0;


        //Searching about it I found this solution below that use XOR 
        //First solution works but have a worst complexity
        //Second solution: https://app.codility.com/demo/results/trainingDMUG69-UQA/
        //Detected time complexity:O(N) or O(N* log(N))
        int element = 0;
        for(int i = 0; i < A.Length; i++)
        {
            //XOR
            element ^= A[i];
        }
        return element;
    }
}