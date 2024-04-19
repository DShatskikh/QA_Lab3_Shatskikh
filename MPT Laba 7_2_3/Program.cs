using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPT_Laba_6_2_3
{
    /// Иконка:
    /// <img src="C:\Users\s-den\Documents\Programming\Visual Studio\QA_Lab3_Shatskikh\MPT Laba 7_2_3\Icon.png" width="400" height="400" />
    /// <summary>
    /// Отсюда запускается программа
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            HelpClass _helpClass1 = new HelpClass();
            HelpClass1 _helpClass2 = new HelpClass1();
            HelpClass2 _helpClass3 = new HelpClass2();

            _helpClass1.Display();
            _helpClass2.Display();
            _helpClass3.Display();
            Console.ReadKey();
        }
    }
}
