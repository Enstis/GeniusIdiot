using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection.Metadata.Ecma335;

int[] a = new int[] { };
int[] b = new int[] { 2 };
Kata kata = new Kata();
var c = kata.ArrayDiff(a, b);

Console.ReadKey();
public class Kata
{
    public  int[] ArrayDiff(int[] a, int[] b)
    {
        return a.Where(val => val != b[0]).ToArray();
    }
}