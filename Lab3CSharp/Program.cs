using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        task1();
        task2();
        static void task1()
        {
            object[,] arr = new object[4, 3]
            {
              {10, 10, "white"},
              {11, 10, "white"},
              {12, 12, "white"},
              {13, 13, "white"}
            };
            for (int i = 0; i < 4; i++)
            {
                Rectangle r = new Rectangle(Convert.ToInt32(arr[i, 0]), Convert.ToInt32(arr[i, 1]), arr[i,2].ToString());
                Console.WriteLine(r.GetsideA());
                Console.WriteLine(r.GetsideB());
                Console.WriteLine(r.CalcAria());
                Console.WriteLine(r.CalcPerimeter());
                Console.WriteLine(r.IsSquare());
                Console.WriteLine("-------");
            }
        }
        static void task2()
        {
            List<List<object>> dynamicArray = new List<List<object>>();
            dynamicArray.Add(new List<object>() { "Joe", 26, "01.01.01", "employee" });
            dynamicArray.Add(new List<object>() { "Tom", 35, "02.01.99", "head", 1 });
            dynamicArray.Add(new List<object>() { "John", 24, "03.01.01", "engeneer", 2, "engineFix"});
            dynamicArray.Add(new List<object>() { "Mark", 44, "11.11.97", "admin", 3, 12345678 });

            for (int i = 0; i < dynamicArray.Count; i++)
            {
                switch (dynamicArray[i][3])
                {
                    case "employee":
                        Worker w = new Worker(dynamicArray[i][0].ToString(), Convert.ToInt32(dynamicArray[i][1]), dynamicArray[i][2].ToString(), dynamicArray[i][3].ToString());
                        w.Show();
                  Console.WriteLine("------");
                        break;
                    case "head":
                        Worker h = new Worker(dynamicArray[i][0].ToString(), Convert.ToInt32(dynamicArray[i][1]), dynamicArray[i][2].ToString(), dynamicArray[i][3].ToString());
                        h.Show();
                  Console.WriteLine("------");
                        break;
                    case "engeneer":
                      Engeneer e = new Engeneer(dynamicArray[i][0].ToString(), Convert.ToInt32(dynamicArray[i][1]), dynamicArray[i][2].ToString(), dynamicArray[i][3].ToString(), Convert.ToInt32(dynamicArray[i][4]), dynamicArray[i][5].ToString());
                        e.Show();
                  Console.WriteLine("------");
                        break;
                case "admin":
                  Admin a = new Admin(dynamicArray[i][0].ToString(), Convert.ToInt32(dynamicArray[i][1]), dynamicArray[i][2].ToString(), dynamicArray[i][3].ToString(), Convert.ToInt32(dynamicArray[i][4]), Convert.ToInt32(dynamicArray[i][5]));
                  a.Show();
                  Console.WriteLine("------");
                  break;
                }
            }
        }
    }
}
public class Rectangle
{
    private int a, b;
    private string c;
    public Rectangle(int a, int b, string c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public int GetsideA()
    {
        return a;
    }
    public int GetsideB()
    {
        return b;
    }
    public int CalcAria()
    {
        return a * b;
    }
    public int CalcPerimeter()
    {
        return (a + b) * 2;
    }
    public bool IsSquare()
    {
        return a == b;
    }
}
public class Worker
{
    public string name { get; set; }
    public int age { get; set; }
    public string birth { get; set; }
    public string Level { get; set; }
    public Worker(string n, int a, string b, string l)
    {
        this.name = n;
        this.age = a;
        this.birth = b;
        this.Level = l;
    }

    public virtual void Show()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(birth);
        Console.WriteLine(Level);
    }
}

public class HeadWorker : Worker
{
    public int privilageLvl { get; set; }
    public HeadWorker(string n, int a, string b, string l, int p) : base(n, a, b, l)
    {
        this.privilageLvl = p;
    }
    public override void Show()
    {
        base.Show();
        Console.WriteLine(privilageLvl);
    }
}
public class Engeneer : HeadWorker
{
    public string skill { get; set; }
    public Engeneer(string n, int a, string b, string l, int p, string skill) : base(n, a, b, l, p)
    {
        this.skill = skill;
    }
    public override void Show()
    {
        base.Show();
        Console.WriteLine(skill);
    }
}
public class Admin : HeadWorker
{
    public int accesKey { get; set; }
    public Admin(string n, int a, string b, string l, int p, int ak) : base(n, a, b, l, p)
    {
        this.accesKey = ak;
    }
    public override void Show()
    {
        base.Show();
        Console.WriteLine(accesKey);
    }
}
