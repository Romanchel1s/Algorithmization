using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate void MyEventHandler(int a, int b);
class MyEvent
{
    MyEventHandler[] evnt = new MyEventHandler[4];
    public event MyEventHandler SomeEvent
    {
        // Добавить событие в список.
        add
        {
            int i;
            for (i = 0; i < 4; i++)
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    break;
                }
            if (i == 4) Console.WriteLine("Список событий заполнен.");
        }
        remove
        {
            int i;
            for (i = 0; i < 4; i++)
                if (evnt[i] == value)
                {
                    evnt[i] = null;
                    break;
                }
            if (i == 4) Console.WriteLine("Обработчик событий не найден.");
        }

    }
    public void OnSomeEvent(int a, int b)
    {
        for (int i = 0; i < 4; i++)
            if (evnt[i] != null) evnt[i](a,b);
    }
}
class W
{
    public void Whandler(int a, int b)
    {
        int c = a+b;
        Console.WriteLine("Сумма = ");
        Console.WriteLine(c);
    }
}
class X
{
    public void Xhandler(int a, int b)
    {
        int c = a-b;
        Console.WriteLine("Разность = ");
        Console.WriteLine(c);
    }
}
class Y
{
    public void Yhandler(int a, int b)
    {
        int c = a*b;
        Console.WriteLine("Произведение = ");
        Console.WriteLine(c);
    }
}
class Z
{
    public void Zhandler(int a, int b)
    {
        if (b == 0) Console.WriteLine("Нельзя");
        else {
        int c = a/b;
        Console.WriteLine("Деление = ");
        Console.WriteLine(c);
        }
    }
}
class EventDemo5
{
    static void Main()
    {
        Console.WriteLine("Введите 2 числа");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        MyEvent evt = new MyEvent();
        W wOb = new W();
        X xOb = new X();
        Y yOb = new Y();
        Z zOb = new Z();

        // Добавить обработчики в цепочку событий.
        evt.SomeEvent += wOb.Whandler;
        evt.SomeEvent += xOb.Xhandler;
        evt.SomeEvent += yOb.Yhandler;
        evt.SomeEvent += zOb.Zhandler;
        Console.WriteLine();
        evt.OnSomeEvent(a,b);
        Console.WriteLine();
        Console.ReadLine();
    }
}
