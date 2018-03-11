using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Zadania;
using GeneratorT;
using NTest;
using TestyWF.Wizualizatory;

namespace TestyWF
{
    public partial class Form1 : Form
    {
        Zadanie[] pytania = new Zadanie[10];
        Wizualizator[] w;
       
        string[] odpowiedzi;
        Panel[] listaP;
        Test t;
        int ile = 0;
        int ktoryP = 0;
        Button dalej = null;


        public Form1()
        {
            dalej = new Button();
            dalej.Text = "Dalej";
            dalej.Location = new Point(200, 200);
            dalej.Click += new EventHandler(this.dalej_Click);

            GenerateQuestions();

            GenerateNewTest();
        }

        private void GenerateQuestions()
        {
            string[] odp0 = new string[3] { "Warszawa", "Kraków", "Gniezno" };
            pytania[0] = new ZadJednaOdp("Co jest stolicą Polski?", odp0, "Warszawa");

            string[] odp1 = { "1022", "1410", "966" };
            pytania[1] = new ZadJednaOdp("Data chrztu Polski to", odp1, "966");

            string[] odp2 = { "Hel", "Neon", "Tlen", "Azot" };
            string[] poprawne2 = { "Hel", "Neon" };
            pytania[2] = new ZadKilkaOdp("Wybierz gazy szlachetne", odp2, poprawne2);

            pytania[3] = new ZadZNum("Podaj wynik: 2x2 = ", 4);

            pytania[4] = new ZadZNum("Rozwiąż równanie x^2 + 6x = -9", -3);

            string[] odp3 = { "Nirvana", "Korn", "Foo Fighters", "Queens of the Stone Age" };
            string[] poprawne3 = { "Nirvana", "Foo Fighters", "Queens of the Stone Age" };
            pytania[5] = new ZadKilkaOdp("Dave Grohl był członkiem zespołów: ", odp3, poprawne3);

            string[] odp4 = new string[4] { "Fender", "Yamaha", "EverPlay", "Fazioli" };
            pytania[6] = new ZadJednaOdp("Która firma NIE JEST producentem gitar?", odp4, "Fazioli");

            pytania[7] = new ZadZNum("Podaj rok wstąpienia Polski do UE: ", 2004);
            pytania[8] = new ZadZTekst("W jakim mieście założono CD Projekt RED?", "Łódź");
            pytania[9] = new ZadZNum("Podaj kolejną liczbę ciągu geometrycznego: 3, 6, 12...", 24);
        }

        public void SetBtnDalejEnabled(bool enabled)
        {
            this.dalej.Enabled = enabled;
        }

        public void GenerateNewTest()
        {
            this.Controls.Clear();
            InitializeComponent();
            SetBtnDalejEnabled(true);
            ktoryP = 0;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //z uzyciem wyr regularnych
            bool containsLetter = Regex.IsMatch(tbNumberOfQuestions.Text, "[A-Za-z]");

            if (string.IsNullOrWhiteSpace(tbNumberOfQuestions.Text) || containsLetter == true || tbNumberOfQuestions.Text == "0" || Convert.ToInt32(tbNumberOfQuestions.Text) > 10)
            {
                MessageBox.Show("Błędna wartość. Użyto domyślnej = 10");
                ile = 10;
            }
            else
            {
                ile = Convert.ToInt32(tbNumberOfQuestions.Text);
            }
              
            Generator g = new Generator(pytania, ile);
            t = g.generatorPyt();
            odpowiedzi = new string[ile];

            listaP = new Panel[ile];

            this.Controls.Clear();
            w = new Wizualizator[ile];


            wyswietl_test();
        }

        void wyswietl_test()
        {
            this.Controls.Clear();

            this.Controls.Add(dalej);


            if (t.listaPyt[ktoryP].znacznik == 1)
            {
                w[ktoryP] = new WizJednaOdp((ZadJednaOdp)t.listaPyt[ktoryP]);
                w[ktoryP].wypelnijPanel();
                this.Controls.Add(w[ktoryP].p);
            }
            else if (t.listaPyt[ktoryP].znacznik == 2)
            {
                w[ktoryP] = new WizKilkaOdp((ZadKilkaOdp)t.listaPyt[ktoryP]);
                w[ktoryP].wypelnijPanel();
                this.Controls.Add(w[ktoryP].p);
            }
            else if (t.listaPyt[ktoryP].znacznik == 3)
            {
                w[ktoryP] = new WizZNum((ZadZNum)t.listaPyt[ktoryP]);
                w[ktoryP].wypelnijPanel();
                this.Controls.Add(w[ktoryP].p);
            }
            else if (t.listaPyt[ktoryP].znacznik == 4)
            {
                w[ktoryP] = new WizZTekst((ZadZTekst)t.listaPyt[ktoryP]);
                w[ktoryP].wypelnijPanel();
                this.Controls.Add(w[ktoryP].p);
            }
        }

        private void dodajOdp()
        {
            odpowiedzi[ktoryP] = w[ktoryP].pobierzOdp();
        }

        private void dalej_Click(object sender, EventArgs e)
        {
            if (ktoryP < ile - 1)
            {
                dodajOdp();
                ktoryP++;
                wyswietl_test();
            }
            else
            {
                dodajOdp();

                Result result = t.ocenTest(odpowiedzi);

                MessageBox.Show(
                    string.Format("Wyniki testu:\r\nCałkowita liczba punktów = {0}\r\nLiczba uzyskanych punktów = {1}\r\nLiczba odpowiedzi poprawnych lub częsciowo poprawnych = {2}", 
                    result.TotalPointsAmount,
                    result.ResultPointsAmount,
                    result.NumberOfCorrectOrPartiallyCorrectAnswers), 
                    "Wyniki", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1
                    );

                SetBtnDalejEnabled(false);

                GenerateNewTest();
            }
        }

    }
}
