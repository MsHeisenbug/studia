using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadania;
using NTest;

namespace GeneratorT
{
    public class Generator
    {
        protected int ileZadan;
        protected Zadanie[] lista;

        public Generator(Zadanie[] listaPytan, int ile)
        {
            this.ileZadan = ile;
            this.lista = listaPytan;
        }

        public Test generatorPyt()
        {
            Zadanie[] listaTest = new Zadanie[this.ileZadan];
            List<int> listaPom = new List<int>();

            Random los = new Random();
            int losowePyt;

            for (int i = 0; i < ileZadan; i++)
            {
                losowePyt = los.Next(lista.Count());
                while (listaPom.Contains(losowePyt)) { losowePyt = los.Next(lista.Count()); }

                listaPom.Add(losowePyt);

                listaTest[i] = this.lista[losowePyt];
            }

            Test test = new Test(listaTest);

            return test;
        }
    }
}
