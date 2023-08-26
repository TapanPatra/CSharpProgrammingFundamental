﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamental._02_DataTypes.ClassesTheBasics
{
    static public class MyMath
    {
        public static float PI = 3.14f;
        public static bool IsOdd(int x)
        {
            return x % 2 == 1;
        }

        public static int Times2(int x)
        {
            return 2 * x;
        }
    }
    [TestFixture]
    public class StaticClasses
    {
        [Test]
        public void StaticClassExample()
        {
            int val = 3;
            Console.WriteLine("{0} is odd is {1}.", val, MyMath.IsOdd(val));
            Console.WriteLine($"{val} * 2 = {MyMath.Times2(val)}.");
        }
    }
}
