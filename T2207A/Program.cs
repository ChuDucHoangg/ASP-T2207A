using T2207A;
using System.Collections.Generic;
public class Progamn
{
    public static void Main(String[] args)
    {
        //Console.WriteLine("Hello world! ABC");
        //int x = 10;
        //string s = "t2207a";
        //double pi = 3.14159;

        //if (x > 5)
        //{
        //    x--;
        //}
        //else
        //{
        //    x++;
        //}
        //int[] arr = new int[5];
        //arr[0] = 1;
        //arr[1] = 93;
        //arr[2] = 48;
        //arr[3] = 14;
        //arr[4] = -14;

        //foreach(int i in arr)
        //{
        //    Console.WriteLine(i);
        //}

        //string cmd = Console.ReadLine();
        //Console.WriteLine("Chuoi vua nhap: " + cmd);

        string cmd2 = Console.ReadLine();
        int n = Convert.ToInt32(cmd2);
        Console.WriteLine("So vua nhap: " + n);
        if (isPrimed(n))
        {
            Console.WriteLine(n + "la so nguyen to");
        }

        List<int> ints = new List<int>();
        ints.Add(4);
        ints.Add(10);
        Student st = new Student();
        st.Run();
    }
    public static bool isPrimed(int n)
    {
        if (n < 2)
            return false;
        if (n < 4)
            return true;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}