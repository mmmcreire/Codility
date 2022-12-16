//First solution: https://app.codility.com/demo/results/trainingXERXD9-WHX/
//Detected time complexity: O(N * N)

int[] Array = { 3, 1, 2, 4, 3 };
Console.WriteLine(Solution.solution(Array));

class Solution
{
    public static int solution(int[] A)
    {
        //First solution: https://app.codility.com/demo/results/trainingXERXD9-WHX/
        //Detected time complexity: O(N * N)
        //int P = 1;
        //int result = Int32.MaxValue;
        //List<int> list = new List<int>();
        //int sumA = 0;
        //int sumP = 0;
        //int aux = 0;
        //while(P < A.Length)
        //{
        //    for(int i = 0; i < P; i++)
        //    {
        //        sumA = sumA + A[i];
        //    }

        //    for(int j = P; j < A.Length; j++)
        //    {
        //        list.Add(A[j]);
        //    }

        //    for(int k = 0; k < list.Count; k++)
        //    {
        //        sumP = sumP + list[k];
        //    }

        //    aux = Math.Abs(sumA - sumP);
        //    result = Math.Min(result, aux);

        //    sumA = 0;
        //    sumP = 0;
        //    list.Clear();

        //    P++;
        //}
        //return result;

        //Secod solution: https://app.codility.com/demo/results/trainingE95VED-RZB/
        //Detected time complexity: O(N)
        int total = 0;
        int result = Int32.MaxValue;
        int previous = 0;
        int next = total;

        for(int i = 0; i < A.Length; i++)
            total += A[i];

        for(int p = 1; p < A.Length; p++)
        {
            previous += A[p - 1];
            next = total - previous;
            result = Math.Min(result, Math.Abs(previous - next));
        }

        return result;

    }
}