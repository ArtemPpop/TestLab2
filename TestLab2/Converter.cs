global using NUnit.Framework;
using System;

public class Converter
{
    public static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber < 0)
        {
            throw new ArgumentException("�� ����������� �����");
        }
        return Convert.ToString(decimalNumber, 2);
    }
}