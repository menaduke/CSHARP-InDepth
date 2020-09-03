﻿using CSHARP_InDepth._1._1._3;
using CSHARP_InDepth._1._1._4;
using System;

namespace CSHARP_InDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please comment a section/region to see how it resolves");
            #region 1.1.3
            //ImplementSimpleDataAccessWithLINQ();
            #endregion 1.1.3

            #region 1.1.4
            //ImplementAsynchrony();
            #endregion 1.1.4

            #region
        }

        static void ImplementSimpleDataAccessWithLINQ()
        {
            #region SimpleDataAccessWithLINQ 1.1.3 START
            SimpleDataAccessWithLINQ CSHARP_InDepth_113 = new SimpleDataAccessWithLINQ();
            CSHARP_InDepth_113.MainInitializer();
            #endregion SimpleDataAccessWithLINQ 1.1.3 END
        }

        static void ImplementAsynchrony()
        {
            #region Asynchrony 1.1.3 START
            Asynchrony CSHARP_InDepth_114 = new Asynchrony();
            CSHARP_InDepth_114.MainInitializerAsync();
            #endregion Asynchrony 1.1.3 END
        }

    }
}
