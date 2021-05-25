using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gectikaldi
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal exam_1, exam_2, exam_3, firstaverage, secondaverage;

            Console.Write("1.Sınav notunu giriniz = ");

            exam_1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("2.Sınav notunu giriniz = ");

            exam_2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            firstaverage = (exam_1 + exam_2) / 2;

            if (firstaverage < 50)
            {
                Console.WriteLine(" İlk iki sınav ortalamanız " + firstaverage.ToString() + " olduğu için 3. Sınava gireceksiniz. ");

                Console.WriteLine("");

                Console.Write("3.Sınav notunu giriniz = ");

                exam_3 = Convert.ToDecimal(Console.ReadLine());

                secondaverage = (exam_1 + exam_2 + exam_3) / 3;

                if(secondaverage <50)
                {
                    Console.WriteLine("Başarısız oldunuz!");
                }

                else
                {
                    Console.WriteLine("Tebrikler, Geçtiniz!");
                }
            }

            else
            {
                Console.WriteLine("Tebrikler, Geçtiniz !");
            }
        }
    }
}
