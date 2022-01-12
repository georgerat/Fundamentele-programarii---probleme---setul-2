using System;

namespace Probleme___setul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
        }

        private static void P15()
        {
            //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
            //De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere.Sa se determine daca este bitonica.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, numar_anterior, k = 0;
            numar_anterior = int.Parse(t[0]);
            bool ok = true;

            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < numar_anterior)
                    k = 1;
                if (k == 1)
                {
                    if (numar > numar_anterior)
                        ok = false;
                }
                numar_anterior = numar;
            }
            if (k == 1 && ok)
                Console.WriteLine("Secventa data este o secventa bitonica");
            else
                Console.WriteLine("Secventa data nu este o secventa bitonica");
        }

        private static void P14()
        {
            //O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri
            //succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, numar_anterior, k = 0, c = 0;
            numar_anterior = int.Parse(t[0]);

            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);

                if (numar < numar_anterior)
                    k++;
                if (numar > numar_anterior)
                    c++;

                numar_anterior = numar;
            }
            if (k <= 1 || c <= 1)
                Console.WriteLine("Secventa data este o secventa monotona rotita.");
            else
                Console.WriteLine("Secventa data nu este o secventa monotona rotita.");
        }

        private static void P13()
        {
            //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o
            //secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie
            //spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, numar_anterior, k = 0;
            numar_anterior = int.Parse(t[0]);

            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);

                if (numar < numar_anterior)
                    k++;

                numar_anterior = numar;
            }
            if (k <= 1)
                Console.WriteLine("Secventa data este o secventa crescatoare rotita.");
            else
                Console.WriteLine("Secventa data nu este o secventa crescatoare rotita.");
        }

        private static void P12()
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca
            //fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, numar_anterior, k = 0;
            numar_anterior = int.Parse(t[0]);
            if (numar_anterior != 0)
                k++;

            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);

                if (numar != 0 && numar_anterior == 0)
                {
                    k++;
                }

                numar_anterior = numar;
            }
            Console.WriteLine($"Sunt {k} grupuri de numere consecutive diferite de zero in secventa data.");
        }

        private static void P11()
        {
            //Se da o secventa de n numere nenule. Se cere sa se caculeze suma inverselor acestor numere.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            double numar, suma = 0;

            for (int i = 0; i < n; i++)
            {
                numar = double.Parse(t[i]);
                suma = suma + (1 / numar);
            }
            Console.WriteLine($"Suma inverselor numerelor din secventa data este: {suma}.");
        }

        private static void P10()
        {
            //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, numar_anterior, lc = 1, lmax = 1;
            numar_anterior = int.Parse(t[0]);

            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);

                if (numar == numar_anterior)
                {
                    lc++;
                    if (lc > lmax)
                        lmax = lc;
                }
                else
                    lc = 1;

                numar_anterior = numar;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este: {lmax}.");
        }

        private static void P9()
        {
            //Sa se determine daca o secventa de n numere este monotona.
            //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, numar_anterior;
            bool crescator = true;
            bool descrescator = true;
            numar_anterior = int.Parse(t[0]);

            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);

                if (numar < numar_anterior)
                    crescator = false;

                if (numar > numar_anterior)
                    descrescator = false;

                numar_anterior = numar;
            }

            if (crescator || descrescator)
                Console.WriteLine("Secventa este monotona.");
            else
                Console.WriteLine("Secventa nu este monotona.");
        }

        private static void P8()
        {
            //Determianti al n - lea numar din sirul lui Fibonacci.
            //Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n - 1) + f(n - 2).Exemplu: 0, 1, 1, 2, 3, 5, 8...
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, r = 1;

            if (n == 1)
            {
                Console.WriteLine($"Primul numar din sirul lui Fibonacci este 0.");
                return;
            }

            for (int i = 3; i <= n; i++)
            {
                r = a + b;
                a = b;
                b = r;
            }
            Console.WriteLine($"Al {n} - lea numar din sirul lui Fibonacci este {r}.");
        }

        private static void P7()
        {
            //Se da o secventa de n numere.Sa se determine cea mai mare si cea mai mica valoare din secventa.
            int n, ValoareMaxima = int.MinValue, ValoareMinima = int.MaxValue;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar > ValoareMaxima)
                    ValoareMaxima = numar;
                if (numar < ValoareMinima)
                    ValoareMinima = numar;
            }
            Console.WriteLine($"Cea mai mare valoare din secventa este {ValoareMaxima}, iar cea mai mica valoare din secventa este {ValoareMinima}.");
        }

        private static void P6()
        {
            //Se da o secventa de n numere.Sa se determine daca numerele din secventa sunt in ordine crescatoare.
            int n, k = -1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar >= k)
                    k = numar;
                else
                {
                    Console.WriteLine($"Cele {n} numere nu sunt in ordine crescatoare.");
                    return;
                }
            }
            Console.WriteLine($"Cele {n} numere sunt in ordine crescatoare.");
        }

        private static void P5()
        {
            //Cate elemente dintr - o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
            //Se considera ca primul element din secventa este pe pozitia 0.
            int n, k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar == i)
                    k++;
            }
            if (k == 1)
                Console.WriteLine($"Un singur numar este egal cu pozitia lui din sir.");
            else
                Console.WriteLine($"Sunt {k} numere egale cu pozitia lor din sir.");
        }

        private static void P4()
        {
            //Se da o secventa de n numere.Determinati pe ce pozitie se afla in secventa un numara a.
            //Se considera ca primul element din secventa este pe pozitia zero.Daca numarul nu se afla in secventa raspunsul va fi -1.
            int n, a;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            int numar;

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar == a)
                {
                    Console.WriteLine($"Numarul {a} se afla pe pozitia {i}.");
                    return;
                }
            }
            Console.WriteLine(-1);
        }

        private static void P3()
        {
            //Calculati suma si produsul numerelor de la 1 la n.
            int n, s = 0, p = 1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s = s + i;
                p = p * i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este {s}, iar produsul lor este {p}.");
        }

        private static void P2()
        {
            //Se da o secventa de n numere.Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
            int n, negative = 0, zero = 0, pozitive = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < 0)
                    negative++;
                else if (numar == 0)
                    zero++;
                else if (numar > 0)
                    pozitive++;
            }
            Console.WriteLine($"Sunt {negative} numere negative, {zero} numere egale cu zero si {pozitive} numere pozitive.");
        }

        private static void P1()
        {
            //Se da o secventa de n numere.Sa se determine cate din ele sunt pare.
            int n, k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar % 2 == 0)
                    k++;
            }

            if (k == 1)
                Console.WriteLine($"In secventa data este un singur numar par.");
            else
                Console.WriteLine($"In secventa data sunt {k} numere pare.");
        }
    }
}
