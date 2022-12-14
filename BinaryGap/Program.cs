//https://app.codility.com/demo/results/training4X9Q3D-UN8/

int n = Int32.Parse(Console.ReadLine());
Console.WriteLine(Solution.solution(n));

class Solution
{
    public static int solution(int N)
    {
        string binaryNumber = Convert.ToString(N, 2);
        int longSequence = 0;
        int aux = 0;
        for(int i = 0; i < binaryNumber.Length; i++)
        {
            if(binaryNumber[i].Equals('0'))
            {
                aux++;
            }
            else
            {
                if(aux > longSequence)
                {
                    longSequence = aux;
                }
                aux = 0;
            }
        }
        return longSequence;
    }
}
