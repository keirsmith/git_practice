using System;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

           /*  bool isMale = false;
            bool isTall = true;

            if(isMale && isTall) 
            {
              Console.WriteLine("You are a tall male");

           } else if (isMale && !isTall)
            {
               Console.WriteLine("You are a short male");

            } else if (!isMale && isTall)
            {
               Console.WriteLine("You are not male but you are tall");
               
            } else
            {
               Console.WriteLine("You are not a male and not tall");
            }
                  */
            Console.WriteLine(GetMax(10, 7, 88));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if(num1 > num2)
            {
            result = num1;
            }
            else {
                result = num2;
            }



            return result;
        }
    }
}
