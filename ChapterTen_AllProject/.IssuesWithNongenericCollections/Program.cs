using System;
using System.Collections;

WorkWithArrayList();

static void SimpleBoxUnboxOperation()
{
    int myInt = 25;
    object boxeInt = myInt;
    int unboxedInt = (int) boxeInt;
}

static void WorkWithArrayList()
{
    ArrayList myInts = new ArrayList();
    myInts.Add(10);
    myInts.Add(20);
    myInts.Add(35);
    int i = (int) myInts[0];
    Console.WriteLine(i);
}

