public class Program
{
    static void Swap<T>(ref T v1, ref T v2){
        T temp = v1;
        v1 = v2;
        v2 = temp;
    }
    static T Sum<T>(T a, T b){
        return (dynamic)a + (dynamic)b;
    }
    static void Sort<T>(T[] arr){
        for(int i=0; i<arr.Length-1; i++)
            for(int j=i+1; j<arr.Length; j++)
                if(arr[i].ToString().CompareTo(arr[j].ToString()) > 0)
                    Swap<T>(ref arr[i], ref arr[j]);
    }
    public static void Main(string[] args){
        Console.Clear();
        int a = 1, b = 2;
        //Swap<int>(ref a, ref b);
        //Console.WriteLine(a + " " + b);
        //Console.WriteLine(Sum<int>(a, b));

        string s1 = "Hello", s2 = "World";
        //Swap<string>(ref s1, ref s2);
        //Console.WriteLine(s1 + " " + s2);
        //Console.WriteLine(Sum<string>(s1, s2));

        int[] arr = {3, 5, 1};
        string[] arr2 = {"Hello", "World", "Alpha"};
        Sort<int>(arr);
        Console.WriteLine(string.Join(" ", arr));
        Sort<string>(arr2);
        Console.WriteLine(string.Join(" ", arr2));
    }
}
