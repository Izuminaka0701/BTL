using System.Collections;
using System.Formats.Tar;

public class Program
{
    public static Array GenericGenArray<T>(int len){
        Array arr = Array.CreateInstance(
            typeof(T),
            new int[]{5},
            new int[]{0}
        );
        Random rand = new Random(100);
        for(int i=0; i<len-1; i++)
            arr.SetValue(rand.Next(1, 100), i);
        return arr;
    }
    public static Array GenArray(int len){
        Array arr = Array.CreateInstance(
            typeof(Int32),
            new int[]{len},
            new int[]{0}
        );
        Random rand = new Random(100);
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            arr.SetValue(rand.Next(1, 100), i);
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            Console.Write(arr.GetValue(i)+", ");
        return arr;
    }
    public static Array Gen2DArray(int len1, int len2){
        Array arr = Array.CreateInstance(
            typeof(Int32),
            new int[]{len1, len2},
            new int[]{0, 0}
        );
        Random rand = new Random(100);
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
                arr.SetValue(rand.Next(1, 100), i, j);//arr[i, j] = ?
        /*for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            Console.Write(arr.GetValue(i)+", ");*/
        return arr;
    }
    public static int SumArray(Array arr){
        int sum = 0;
        foreach(int i in arr)
            sum += i;
        return sum;
    }
    public static int Sum2DArray(Array arr){
        /*int sum = 0;
        foreach(int i in arr)
            sum += i;*/
        return SumArray(arr);
    }
    private static void Print2DArray(Array arr){
    for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0);i++){
      for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
        Console.Write(arr.GetValue(i, j) + ", ");
      Console.WriteLine("");
    }
  }
    public static void Main(string[] args)
    {
        /* int[] arr = new int[5];
        arr[0] = 3; arr[1] = 5; arr[2] = 7; 
        arr[3] = 9; arr[4] = 11;*/
        //Array arr = GenArray(5);
        //Console.WriteLine("Sum: " + SumArray(arr));
        /*Array arr2 = Gen2DArray(3, 4);
        Print2DArray(arr2);
        Console.WriteLine("Sum: " + Sum2DArray(arr2));*/
        //arr.GetValue(index)   //arr.SetValue(value, index)

        /*List<int> list = new List<int>();
        list.Add(3);
        list.AddRange(new int[]{5, 7, 9, 11});
        list.Remove(5);//Xoá phần tử có giá trị 5
        list.RemoveAt(0);//Xoá phần tử tại vị trí 0
        Console.WriteLine(list.Contains(6));
        //Kiểm tra phần tử có tồn tại trong list không
        //Lấy phần tử đầu tiên của list, tức số 9 cộng thêm 2
        Console.WriteLine(list[0] + 2);

        ArrayList arlist = new ArrayList();
        arlist.Add(3);
        arlist.AddRange(new int[]{5, 7, 9, 11});
        arlist.Remove(5);//Xoá phần tử có giá trị 5
        arlist.RemoveAt(0); //Xoá phần tử tại vị trí 0
        Console.WriteLine(arlist.Contains(6));
        //Kiểm tra phần tử có tồn tại trong list không
        //Lấy phần tử đầu tiên của list, tức số 9 cộng thêm 2
        Console.WriteLine((int)arlist[0] + 2);*/

        List<int> list = GenerateList(1, 3, 4, 2, 5, 9);
        PrintList(list);
    }
    static List<T> GenerateList<T>(params T[] elements){
        List<T> result = new List<T>();
        foreach(T element in elements)
            result.Add(element);
        return result;
    }
    static void PrintList<T>(List<T> list){
        foreach(T element in list)
            Console.Write(element + ", ");
        Console.WriteLine("");
    }
    static void Sort<T>(List<T> list)
    {
        list.Sort();
        /*Console.WriteLine("Sorted list: ");
        foreach(T element in list)
            Console.Write(element + ", ");*/
    }
    static List<T> GetPythagoreanTrimplets<T>(List<T> list) {
        for (int i = 0; i < list.Count; ++i)
            for (int j = i + 1; j < list.Count; ++j)
                for (int k = j + 1; k < list.Count; ++k)
                    if ((dynamic)list[i] * list[i] + (dynamic)list[j] * list[j] == (dynamic)list[k] * list[k])
                        return new List<T> { list[i], list[j], list[k] };
        return null;
    }
    static List<T> GetIntSquaredNumber<T>(List<T> list) {
        List<T> newslist = new List<T>();
        foreach (T i in list)
        {
            double concect = Convert.ToDouble(i);
            if (concect >= 0)
            {
                double sqrt = Math.Sqrt(concect);
                if (sqrt == (int)sqrt)
                    newslist.Add(i);
            }
        }
        Console.WriteLine(string.Join(", ", newslist));
        return newslist;
    }
}
