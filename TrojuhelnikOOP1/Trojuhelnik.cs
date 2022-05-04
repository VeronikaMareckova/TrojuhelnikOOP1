using System;
using System.Collections.Generic;
using System.Text;

namespace TrojuhelnikOOP1
{
    class Trojuhelnik
    {
        //Atributy
        private double a;
        private double b;
        private double c;

        //Vlastnosti ----

        //Metody GET
        public double GetA()
        {
            return a;
        }
        public double GetB()
        {
            return b;
        }

        public double GetC()
        {
            return c;
        }

        //Metody SET (nastaveni hodnot)
        public void SetA(double value)
        {
            if (value > 0.0) //podminka kladne cislo
                a = value;
        }

        public void SetB(double value)
        {
            if (value > 0.0)
                b = value;
        }

        public void SetC(double value)
        {
            if (value > 0.0)
                c = value;
        }

        //metoda vola dalsi metody
        public void SetAll(double a, double b, double c)
        {
            SetA(a);
            SetB(b);
            SetC(c);
        }

        //-----------
        public double spoctiObvod()
        {
            return GetA() + GetB() + GetC(); //return a + b + c;
        }

        public double spoctiObsah()
        {
            double s = spoctiObvod() / 2; //obvod trojuhelniku / 2
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); //Heronuv vzorec
        }

        //metoda pro overeni 
        public bool isValid()
        {
            //return (a + b) > c && (a + c) > b && (b + c) > a;
            return (GetA() + GetB()) > GetC()
                && (GetA() + GetC()) > GetB()
                && (GetB() + GetC()) > GetA();

        }
    }
}
