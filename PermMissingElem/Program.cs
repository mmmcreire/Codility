//https://app.codility.com/demo/results/training35ZZ7A-CJ5/ (check comments below)
//https://app.codility.com/demo/results/trainingHK8D6Z-6WZ/

int[] Array = { 5 };
Console.WriteLine(Solution.solution(Array));

class Solution
{
    public static int solution(int[] A)
    {
        //First solution: https://app.codility.com/demo/results/trainingHK8D6Z-6WZ/
        //Detected time complexity: O(N)
        if(A.Length == 0)
        {
            return 1;
        }
        if(A.Length == 1)
        {
            if(A[0] >= 1)
            {
                if(A[0] == 2)
                {
                    return 1;
                }
                else
                {
                    return A[0] + 1;
                }
            }
            else
            {
                return 1;
            }
        }

        List<int> sortedList = new List<int>(A);
        sortedList.Sort();
        A = sortedList.ToArray();

        int result = -1;
        int shouldBe = 0;

        for(int i = 0; i < A.Length; i++)
        {
            shouldBe = A[i] + 1;

            if((i < A.Length - 1) && (A[i + 1] != shouldBe))
            {
                result = shouldBe;
                break;
            }
        }

        if(result == -1)
        {
            if((A[0] - 1) <= 0)
            {
                return shouldBe;
            }
            else
            {
                return A[0] - 1;
            }
        }

        return result;

        //Even getting 100% I didn't agree with some results/tests so I searched about this and I found this solution that is based on Codility PDF training material.
        //This solution passed in all Correctness tests but didn't pass in Performance test.
        //The issue here is that the array should never have a single element. Example: If I have the array A={2}, how can I know if the missing element is 1 or 3?
        //And if A={5}? Missing element is 6 or 4? On my solution I have the answer 6 and on the solution below I have -2. How can answer this pass on Correctness test?
        //So, in my opnion the array A should have at least 2 elements

        //Second solution: https://app.codility.com/demo/results/trainingUDBFP6-46W/
        //Detected time complexity: O(N)
        //int N = A.Length + 1;
        //int sum = N * (N + 1) / 2;
        //for(int i = 0; i < A.Length; i++)
        //{
        //    sum -= A[i];
        //}
        //return sum;
    }
}
