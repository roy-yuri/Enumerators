// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Linq;

Console.WriteLine("Hello, World!");

for (var e = new MyRange(12, 31); e.MoveNext();)
{
    Console.WriteLine(e.Current);
}


public class MyRange : IEnumerator 
{
    private int[] Numbers;
    int position = -1;

    public MyRange(int min, int max)
    {
        // Constructor
        // +1 because index starts from 0
        Numbers = new int[max-min+1];
        for (int i = 0; i < max-min+1; i++)
        {
            Numbers[i] = min+i;
        }
    }

    public object Current
    {
        get
        {
            if (position == -1 || position >= Numbers.Length)
                throw new InvalidOperationException();
            return Numbers[position];
        }
    }

    public bool MoveNext()
    {
        if (position < Numbers.Length - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }
        public void Reset()
    {
        position = -1;
    }


}
