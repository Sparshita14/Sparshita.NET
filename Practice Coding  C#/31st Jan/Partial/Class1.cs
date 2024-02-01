using System;
public partial class A
{
    public void m1()
    {
        Console.WriteLine("first method");
    }
    partial pm();
}
public partial class A
{
    public void m2()
    {
        Console.WriteLine("Second method");
    }
    partial void pm(int a)
    {
        Console.WriteLine("a");
    }


}
