//Solution: https://app.codility.com/demo/results/trainingY9J8JZ-TAA/
//Detected time complexity: O(N)

int[] Array = { -1, -3, 0, 1 };
Console.WriteLine(Solution.solution(Array));

class Solution
{
    public static int solution(int[] A)
    {
        if(A.Max() < 0)
        {
            return 1;
        }
        int result = 0;

        List<int> sortedList = new List<int>(A);
        sortedList.RemoveAll(x => x <= 0);
        sortedList.Sort();
        HashSet<int> set = new HashSet<int>(sortedList);
        sortedList = new List<int>(set);
        for(int i = 0; i < sortedList.Count; i++)
        {
            if(sortedList[i] != (i + 1))
            {
                return i + 1;
            }

            result = i + 1;
        }
        return result + 1;
    }
}