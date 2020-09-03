using CSHARP_InDepth._1._1._3;
using CSHARP_InDepth._1._1._4;
using CSHARP_InDepth._2._1;
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

            #region 2.1
            ImplementGenerics();
            #endregion 2.1
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
            #region Asynchrony 1.1.4 START
            Asynchrony CSHARP_InDepth_114 = new Asynchrony();
            CSHARP_InDepth_114.MainInitializerAsync();
            #endregion Asynchrony 1.1.4 END
        }
        static void ImplementGenerics()
        {
            //Enums can’t be generic, but classes, structs, interfaces, and delegates all can be
            #region Generics 2.1 START
            Generics CSHARP_InDepth_21 = new Generics();
            CSHARP_InDepth_21.MainInitializerAsync();
            #endregion Generics 2.1  END
        }

    }
}
