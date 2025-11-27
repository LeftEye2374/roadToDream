using AutoLot.Dal.BulkImport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

public sealed class MyDataReader<T> : IMyDataReader<T>
{
    private int _currentIndex = -1;

    public List<T> Records { get; set; }


    public MyDataReader(List<T> reacords)
    {
        Records = reacords;
    }

    public bool Read()
    {
        if (_currentIndex + 1 >= Records.Count)
        {
            return false;
        }
        _currentIndex++;
        return true;
    }
}