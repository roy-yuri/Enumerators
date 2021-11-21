// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

Console.WriteLine("Hello, World!");

MyRange a = new MyRange(2, 5);


public class MyRange //: IEnumerable 
{
    private int[] Numbers;

    public MyRange(int min, int max)
    {
        // Constructor
        Numbers = new int[max-min];
        for (int i = 0; i < max-min; i++)
        {
            Numbers[i] = min+i;
        }
    }


}