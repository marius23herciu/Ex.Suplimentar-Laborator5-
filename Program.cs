using System;

namespace Ex.Suplimentar_Laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitiu suplimentar
            //Catalog
            //Scrieti un program care va citi de la tastatura un numar n de elevi.
            //Elevii vor avea nume, prenume precum si un numar de note m specific fiecarui
            //elev si citit si el de la tastatura.
            //Notele fiecarui elev vor fi la randul lor citite de la tastatura.
            // Programul va afisa informatiile elevului cu media cea mai mare
            //nume, prenume ,medie generala

            Console.WriteLine("Introduceti numarul de elevi pe care doriti sa il introduceti in catalog:");
            int n = int.Parse(Console.ReadLine());

            string[] nume = new string[n];
            string[] prenume = new string[n];
            InroducereEleviCatalog(nume, prenume);

            double[][] noteElevi = new double[n][];
            noteElevi = IntroducereNote(nume, prenume, noteElevi);

            string medieMare = AfisareElevMedieMax(nume, prenume, noteElevi);
            Console.WriteLine(medieMare);
        }
        static string[] InroducereEleviCatalog(string[] nume, string[] prenume)
        {
            for (int i = 0; i < nume.Length; i++)
            {
                Console.WriteLine("Introduceti numele:");
                nume[i] = Console.ReadLine();
                Console.WriteLine("Introduceti prenumele:");
                prenume[i] = Console.ReadLine();
            }

            return nume;
        }
        static double[][] IntroducereNote(string[] nume, string[] prenume, double[][] noteElevi)
        {
            for (int i = 0; i < noteElevi.Length; i++)
            {
                string elevCurent = nume[i] + " " + prenume[i];
                Console.WriteLine($"Cate note introduceti pentru elevul {elevCurent}?", elevCurent);
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine($"Introduceti {m} note:", m);
                noteElevi[i] = new double[m];
                for (int j = 0; j < m; j++)
                {
                    noteElevi[i][j] = double.Parse(Console.ReadLine());
                }
            }

            return noteElevi;
        }
        static string AfisareElevMedieMax(string[] nume, string[] prenume, double[][] noteElevi)
        {
            string rezultat = String.Empty;
            double medieMare = 0;
            for (int i = 0; i < noteElevi.Length; i++)
            {
                double medieCurenta = 0;
                for (int j = 0; j < noteElevi[i].Length; j++)
                {
                    medieCurenta += noteElevi[i][j];
                    if (j == noteElevi[i].Length - 1)
                    {
                        medieCurenta = medieCurenta / noteElevi[i].Length;
                    }
                }
                if (medieCurenta > medieMare)
                {
                    medieMare = medieCurenta;
                    rezultat = String.Empty;
                    rezultat = ($"Elevul {nume[i]} {prenume[i]} a avut cea mai mare medie, respectiv {medieMare.ToString("n2")}.").ToString();
                }
            }

            return rezultat;
        }
    }
}
