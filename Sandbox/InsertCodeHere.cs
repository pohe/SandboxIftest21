using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            TestIf();
            Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }


        public void TestIf()
        {
            int age = 25;
            Console.WriteLine("Starting to check age...");

            if (age < 18)
            {
                Console.WriteLine("You are still a child...");
            }

            if (age < 18)
                Console.WriteLine("You are still a child...");
            else
                Console.WriteLine("You are an adult!");
            Console.WriteLine("Finished checking age");


            if (age > 12)
            {
                if (age < 20)
                {
                    Console.WriteLine("You are a teenager");
                }
            }

            if ((age < 20) && (age > 12))
            {
                Console.WriteLine("You are a teenager");
            }

            if ( !( (age<=12)|| (age>=20) ) )
            {
                Console.WriteLine("You are a teenager");
            }

            //int age = 15;
            string message = "You are ";

            if (age < 18)
            {
                message = message + "a child.";
            }
            else
            {
                message = message + "an adult.";
            }


            message = message + ((age < 18) ? "a child." : "an adult.");




            int score = 25;
            if (score >= 90)
            {
                Console.WriteLine("Mark is: A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Mark is: B");
            }
            else if (score >= 40)
            {
                Console.WriteLine("Mark is: C");
            }
            else
            {
                Console.WriteLine("Mark is: D");
            }
            int noOfChildren = 1;
            int childSupport=0;
            switch (noOfChildren)
            {
                case 0:
                    childSupport = 0;
                    break;
                case 1:
                    childSupport = 1200;
                    break;
                case 2:
                    childSupport = 2000;
                    break;
                case 3:
                    childSupport = 2600;
                    break;
                default:
                    childSupport = 3000;
                    break;
            }

            string selector = "test";
            switch (selector)
            {
                case "123": 
                    childSupport = 500;
                    break;
                case "test":
                    childSupport = 1500;
                    break;
            }

            double selectord = 12.4;


            switch (selectord)
            {
                case 12.4:
                    childSupport = 500;
                    break;
                case 12.5:
                    childSupport = 1500;
                    break;
            }
        }
    }
}