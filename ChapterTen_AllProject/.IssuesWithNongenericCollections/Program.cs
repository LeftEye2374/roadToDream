using System;
using System.Collections;

static void SimpleBoxUnboxOperation()
{
    int myInt = 25;
    object boxeInt = myInt;
    int unboxedInt = (int) boxeInt;
}
