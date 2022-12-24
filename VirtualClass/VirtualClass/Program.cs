// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

D d = new D();
C c = d;
B b = d;
A a = d;

d.Foo();
c.Foo();
b.Foo();
a.Foo();

//D
//C
//C
//A
/*
   D自然输出d，因为以下没有派生
   C输出c，因为D存在new，所以隐藏，那么对于C来说，是B最远的派生
   B输出c，因为C是B最远的派生
   A没有任何基类
 */
Console.Read();

class A
{
    public void Foo()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public virtual void Foo()
    {
        Console.WriteLine("B");
    }
}

class C : B
{
    public override void Foo()
    {
        Console.WriteLine("C");
    }
}

class D : C
{
    public new void Foo()
    {
        Console.WriteLine("D");
    }
}


