using System;

namespace Aghorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.a və b dəyişənləri verilir.3-cü dəyişən olmadan a və b-nin dəyərlərini dəyişin(Məs:a=5,b=6.Nəticə a=6,b=5).
            int a = 6;
            int b = 8;

            a = a + b;
            Console.WriteLine($"Birinci emeliyyatda a:{a}");
            Console.WriteLine($"Birinci emeliyyatda b:{b}");
            b = a - b;
            Console.WriteLine($"Ikinci emeliyyatda a:{a}");
            Console.WriteLine($"Ikinci emeliyyatda b:{b}");
            a = a - b;
            Console.WriteLine($"Ucuncu emeliyyatda a:{a}");
            Console.WriteLine($"Ucuncu emeliyyatda b:{b}");
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion

            #region 2.SpaceCount() metodunun cagirilmasi
            Console.WriteLine("Zehmet olmasa cumleni daxil edin:");
            string word = Console.ReadLine();
            string soz = "Salam";
            SpaceCount(soz);

            #endregion
            #region 3.Word() metodunun cagirilmasi
            string soz1 = Console.ReadLine();
            Console.WriteLine(Word(soz1));
            #endregion

            #region 4.Calculator() metodunun cagirilmasi
            Calculator();
            #endregion

            #region 5.Proses() metodunun cagirilmasi
            Console.WriteLine("Zehmet olmasa reqem daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            Proses(num);
            #endregion


        }
        #region 5.Ədəd daxil edilir.0-dan bu ədədə qədər olan ədədlərdən 3-ə bölünənlərin hasilini,bölünməyənlərin cəmini tapan metod yazın.
        static void Proses(int number){
            int hasil = 1;
            int cem = 0;
            for (int i=1;i<=number;i++)
            {
                if (i % 3 == 0)
                {
                    hasil *= i;
                }
                else
                {
                    cem += i;
                }
            }

            Console.WriteLine($"Hasil = {hasil}");
            Console.WriteLine($"Cem = {cem}");


        }

        #endregion

        #region 2.Verilmiş cümlədə boşluqların sayını tapan metod yazın.
        static void SpaceCount(string soz)
        {
            //int count = 0;
            //foreach (char letter in soz)
            //{
            //    if (letter == ' ')
            //    {
            //        count++;
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("Cumlede boshluq yoxdur");
            //}

            //Console.WriteLine($"Bosluqarin sayi :{count}");

        }

        #endregion


        #region 3.Söz daxil edilir.Həmin sözün hərfləri arasında  "*" işarəsi qoyaraq həmin sözü qaytaran metod yazın (A*z*e*r*b*a*y*c*a*n*).
        static string Word(string words)
        {
            string symbol = "";
            for (int i = 0; i < words.Length; i++)
            {
                symbol += words[i] + "*";
            }
            return symbol;
        }

        #endregion

        #region 4.Toplama,Çıxma,Vurma,Bölmə metodlari olan sade kalkulyator yazın(kəsr ədədləri,string erroru nəzərə alınmadan).
        static int Sum(int number1, int number2)
        {
            int result = 0;
            result = number1 + number2;
            return result;
        }

        static int Minus(int number1, int number2)
        {
            int result = 0;
            result = number1 - number2;
            return result;
        }

        static int Multiple(int number1, int number2)
        {
            int result = 1;
            result = number1 * number2;
            return result;
        }

        static int Divide(int number1, int number2)
        {
            int result = 1;
            result = number1 / number2;

            return result;
        }


        static void Calculator()
        {
            Console.WriteLine("Zehmet olmasa 1-ci reqemi daxil edin:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zehmet olmasa 2-ci reqemi daxil edin:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zehmet olmasa emeliyyati daxil edin");
            string symbol = Console.ReadLine();

            if (symbol == "+")
            {
                Console.WriteLine(Sum(num1, num2));
            }
            else if (symbol == "-")
            {
                Console.WriteLine(Minus(num1, num2));
            }
            else if (symbol == "*")
            {
                Console.WriteLine(Multiple(num1, num2));
            }
            else if (symbol == "/")
            {
                Console.WriteLine(Divide(num1, num2));
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun emeliyyati daxil edin");
            }


        }

        #endregion



    }
}
