using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP
{
    abstract class Dasar
    {
        protected string codeReference, errorInput;
        protected int quantity, numberInt;
        protected int hargaLotre = 100000;
        protected int matchCounter = 0;
        protected string[] lotreCodes = new string[3];
        protected char[] input = new char[5];
        protected char[] codeUndi, newInputs;


        public void Header()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine(" ");
            Console.WriteLine("--------------------|       Betamart        |---------------------");
            Console.WriteLine("--------------------|    Lottery Machine    |---------------------");
            Console.WriteLine(" ");
            Console.WriteLine("==================================================================");
            Console.WriteLine(" ");
        }

        abstract public void Greeting();

       

    }
}
