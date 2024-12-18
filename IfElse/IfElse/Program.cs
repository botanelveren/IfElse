using System;



namespace IfElse

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.Write("Lütfen bir sayı giriniz:");



            string number = Console.ReadLine();



           

            if (int.TryParse(number, out int intNumber))

            {

                int remainder = intNumber % 2; 


                if (intNumber > 10 && remainder == 0)

                {

                    Console.WriteLine("Girilen sayı 10'dan büyüktür.\nGirilen sayı çifttir.");

                }


                else if (intNumber > 10 && remainder != 0)

                {

                    Console.WriteLine("Girilen sayı 10'dan büyüktür.\nGirilen sayı tektir.");

                }

                else if (intNumber < 10 && remainder == 0)

                {

                    Console.WriteLine("Girilen sayı 10'dan küçüktür.\nGirilen sayı çifttir.");

                }

                else if (intNumber < 10 && remainder != 0)

                {

                    Console.WriteLine("Girilen sayı 10'dan küçüktür.\nGirilen sayı tektir.");

                }
                else

                {

                    Console.WriteLine("Girilen sayı 10'dur.");

                }

            }

            else

            {

                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");

            }

        }

    }

}