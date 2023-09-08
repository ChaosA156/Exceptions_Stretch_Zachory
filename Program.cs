using System;
//I am pretty sure that the message for inputting 0 is somewhat messed up. but I don't want to mess anything else up trying to change it.
namespace Exceptions_Stretch_Zachory
{
    class Program
    //Pretty sure this randomly generates a number based on the user's input.
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            //A prompt that asks the user to imput a number other than zero and store their response.
            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            finally
            {
                Console.WriteLine("Calculations complete with a result of " + result);
            }

            //A prompt that checks the age of the user and will tell them if they are too young to play Mature rated games.
            try
            {
                CheckAge(myInt);
            }catch
            {
                Console.WriteLine($"You are {myInt}, you not old enough!");
            }
        }

        static float Divide(float x, float y)
        {
            if(y ==  0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        //A prompt that checks the age of the user and will tell them if they are old enough to play Mature rated games.
        static void CheckAge(int age)
        {
            if(age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
               throw new ArgumentException();
            }
        }
    }
}
