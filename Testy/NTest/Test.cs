using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadania;

namespace NTest
{
    public class Result
    {
        public Result()
        {
            TotalPointsAmount = 0;
            ResultPointsAmount = 0;
            NumberOfCorrectOrPartiallyCorrectAnswers = 0;
        }

        public float TotalPointsAmount;
        public float ResultPointsAmount;
        public int NumberOfCorrectOrPartiallyCorrectAnswers; // dla zadan wielokrotnego wyboru gdy przynjamniej jedna odpowiedz jest poprawna wtedy jest partiallycorrect, gdy wszystkie poprawne to correct
    }
    public class Test
    {
        public Zadanie[] listaPyt;
        protected float wynik;
        public float suma;

        public Test(Zadanie[] lista)
        {
            this.listaPyt = lista;
            this.wynik = 0;
            this.suma = 0;
        }

        public Result ocenTest(string[] odp)
        {
            Result result = new Result();

            for (int i = 0; i < this.listaPyt.Count(); i++)
            {
                bool correctAnswer = (listaPyt[i].sprPyt(odp[i]) == true);
                result.TotalPointsAmount += listaPyt[i].totalPoints;
                result.ResultPointsAmount += listaPyt[i].pkt;
                result.NumberOfCorrectOrPartiallyCorrectAnswers += correctAnswer ? 1 : 0;
            }

            return result;
        }
    }
}

