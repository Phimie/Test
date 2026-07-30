using System;


class Program
{
    static void Main()
    {
        //lambda表达式
        //无参无返回值
        Action a = () =>
        {
            Console.WriteLine("hello");
        }
        a();
        //有参
        Action<int> a2 = (value) =>
        {
            Console.WriteLine("有参{0}", value);
        }
        a2(100);

        //有返回值
        Func<string, int> a3 = (value) =>
        {
            Console.WriteLine("有返回值{0}", value);
            return 1;
        }
        Console.WriteLine(a4("111"));

    }
}