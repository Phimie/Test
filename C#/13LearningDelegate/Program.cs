using System;

//委托是函数(方法)的容器
//可以用来存储,传递函数(方法)
public delegate void MyFun();
//申明了一个表示用来装载或传递返回值为int,且有一个int参数的函数的委托
public delegate int MyFun2(int a);

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("---委托申明与调用---");
        MyFun myFun = new MyFun(Fun);
        myFun.Invoke();

        MyFun2 myFun2 = new MyFun2(Fun2);
        //使用.Invoke()方法调用委托和直接调用委托最终编译结果是一样的
        //传参方式类似于函数
        Console.WriteLine(myFun2(1));

        Console.WriteLine("\n---测试委托作为函数参数---");
        //Test
        Test t = new Test();
        t.TestFun(Fun, Fun2);

        Console.WriteLine("\n---测试多播委托---");
        //多播委托
        myFun += Fun3;
        myFun();

        //使用系统自带委托,需要引用system,比如Action(无参无返回值委托),Func泛型委托
        Action playerAction;
        Func<int, string> testDelegate;


    }

    static void Fun()
    {
        Console.WriteLine("hello");
    }

    static int Fun2(int n)
    {
        return n;
    }

    static void Fun3()
    {
        Console.WriteLine("你好");
    }
}

class Test
{
    //委托还可以用来作为函数的参数
    //好处是可以先处理一些别的逻辑,等这些逻辑处理完了,再执行传入的函数
    public void TestFun(MyFun fun, MyFun2 fun2)
    {
        int i = 1;
        i *= 2;
        i += 2;

        fun();
        fun2(i);
    }
}
