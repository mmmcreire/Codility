//https://app.codility.com/demo/results/trainingW6DVPX-2XC/

int[] Array = { 3, 8, 9, 7 };
Console.WriteLine(String.Join(", ", (Solution.solution(Array, 3))));

class Solution
{
    public static int[] solution(int[] A, int K)
    {
        int[] newArray = new int[A.Length];
        int newIndex = 0;

        for(int i = 0; i < A.Length; i++)
        {
            newIndex = (i + K) % A.Length;
            newArray[newIndex] = A[i];
        }

        return newArray;
    }
}

