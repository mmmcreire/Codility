int[] Array = { 5, 5, 5, 5, 5, 5, 5 };
Console.WriteLine(Solution.solution(5, Array));

class Solution
{
    //First solution: https://app.codility.com/demo/results/trainingG96Z6H-88T/
    //Detected time complexity: O(N ** 2)
    public static int solution(int X, int[] A)
    {
        //First solution: https://app.codility.com/demo/results/trainingG96Z6H-88T/
        //Detected time complexity: O(N ** 2)
        //int jumps = 1;
        //List<int> list = new List<int>();
        //for(int i = 0; i < A.Length; i++)
        //{
        //    if(!(list.Contains(A[i])))
        //    {
        //        list.Add(A[i]);
        //        jumps = i;
        //    }
        //}
        //if(list.Count < X)
        //{
        //    return -1;
        //}
        //else
        //{
        //    return jumps;
        //}

        //Second solution: https://app.codility.com/demo/results/training8XZHGZ-5P6/
        //Detected time complexity: O(N)
        //Instead of using list I used here HashSet, so I don't have to check if the element is on the set because HashSet has only unique values
        //HashSet documentations says: "The HashSet<T> class is based on the model of mathematical sets and provides high-performance set operations..." 
        //"...A HashSet cannot contain duplicate elements. If order or element duplication is more important than performance for your application, consider using the List class"
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < A.Length; i++)
        {
            set.Add(A[i]);
            if(set.Count == X)
                return i;

        }
        return -1;
    }
}