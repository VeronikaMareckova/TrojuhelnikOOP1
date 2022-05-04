using System;

namespace TrojuhelnikOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJEKT (tim se vytvori TR ktery ma neinicializovane hodnoty promennych)
            Trojuhelnik tr = new Trojuhelnik();

            //tr.a = 5; //nejde to z toho duvodu ze ATRIBUTY PROMENNE jsou PRIVATE 
            //tr.b = 4; //takto nemame primi pristup k polozkam TRIDY
            //tr.c = 3; //diky tomu je zachovat princim OOP zapouzdreni


            //Metody set umoznuji nastavit hodnoty stran trojuhelnika
            tr.SetA(6);
            tr.SetB(-3);
            tr.SetC(2.5);

            //Vypis
            Console.WriteLine(tr.GetA()); //6
            Console.WriteLine(tr.GetB()); //0
            Console.WriteLine(tr.GetC()); //2,5


            tr.SetAll(4, 3, 2);
            Console.WriteLine(tr.GetA()); //4
            Console.WriteLine(tr.GetB()); //3
            Console.WriteLine(tr.GetC()); //2

            //ulozeni do promennych (atributu)
            bool overeni = tr.isValid();

            double strana_a = tr.GetA();
            double strana_b = tr.GetB();
            double strana_c = tr.GetC();

            double obvod = tr.spoctiObvod();
            double obsah = tr.spoctiObsah();

            Console.WriteLine("Trojúhelník {0} \n{1} \n{2} \n{3}\n{4}\n{5}", tr.isValid(), tr.GetA(), tr.GetB(), tr.GetC(), tr.spoctiObvod(), tr.spoctiObsah());
        }
    }
}
