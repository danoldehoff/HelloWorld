using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are changing this number to demonstrate how to change public static variables from a different class
            Constants.Number = 4;
            Console.WriteLine(Constants.Number);
            Console.WriteLine("Hello World!");

            if (Constants.Number == 5 && 6 > 5) // if (false && true) --> if (false)
            {
                Console.WriteLine("100");
                Console.Write("Dan");
            }
            else if (Constants.Number > 10 && Constants.Number < 20) // Greater than 10 less than 20
            {
                Console.WriteLine("Hello");
            }
            else if (Constants.Number <= 75)
            {
                System.Console.WriteLine("maybe");
            }
            else
            {
                Console.WriteLine("false");
            }

            //Beep();
            FizzBuzz(5);
        

        private static void Beep()
        {
            Console.Beep(15000, 100000);
        }


        // Fizz Buzz
        // If the number is divisbile by 3, Console.WriteLine("Fizz")
        // Else if the number is divisible by 5, Console.WriteLine("Buzz")
        // Else if the number is divisible by both 3 and 5, Console.WriteLine("Fizz Buzz")
        // Else, do nothing
        private static void FizzBuzz(int number)
        {           

            //double divideByThreeResult = number / 3; // 3 / 3 = 1; 3 / 4 = .75; 3 % 3 = 0; 3 % 2 = 1; 3 % 4 = 3
            //double divideByFiveResult = number / 5; // 3 / 5 = 0.6; 15 / 5 = 3
           
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            //
            
            
        }
    }
}



/*

Boolean is either 0 or 1
aka "Base 2", compared to our typical number system of Base 10

What is 0 + 0 = 0
What is 1 + 0 = 1
What is 1 + 1 = 10

What is 10 + 0 = 10
What is 10 + 1 = 11
What is 11 + 1 = 100

Base 2 | Base 10
-----------------
0      |  0
1      |  1
10     |  2
11     |  3
100    |  4
101    |  5
110    |  6
111    |  7

Boolean Logic

-------
| AND |
-------

Brandon has an apple. Dan has an apple. Do both Brandon and Dan have an apple? Yes! True

Brandon is 1. Dan is 1. Dan and Brandon are both 1? True
Brandon is 1. Dan is 0. Dan and Brandon are both 1? False
Brandon is 0. Dan is 1. Dan and Brandon are both 1? False
Brandon is 0. Dan is 0. Dan and Brandon are both 1? False

1 AND 1 == True
1 AND 0 == False
0 AND 1 == False
0 AND 0 == False

1 AND 1 == True
1 AND 0 == False
0 AND 1 == False
0 AND 0 == False

1 && 1 == True
1 && 0 == False
0 && 1 == False
0 && 0 == False

"Truth Table"

TRUE && TRUE == True
TRUE && FALSE == False
FALSE && TRUE == False
FALSE && FALSE == False

-------
| OR  |
-------

Brandon has an apple. Dan has an apple. Does both Brandon or Dan have an apple? Yes! True

Brandon is 1. Dan is 1. Dan or Brandon are 1? True
Brandon is 1. Dan is 0. Dan or Brandon are 1? True
Brandon is 0. Dan is 1. Dan or Brandon are 1? True
Brandon is 0. Dan is 0. Dan or Brandon are 1? False

"Truth Table"

TRUE  || TRUE  == True
TRUE  || FALSE == True
FALSE || TRUE  == True
FALSE || FALSE == False

TRUE || TRUE || TRUE == True
TRUE || TRUE || FALSE == True
TRUE || FALSE || TRUE == True
TRUE || FALSE || FALSE == True
FALSE || TRUE || TRUE == True
FALSE || FALSE || TRUE == True
FALSE || FALSE || FALSE == FALSE

-------
| NOT |
-------

Brandon has an apple. Does Brandon not have an apple? False

!TRUE == FALSE
!FALSE == TRUE

!(TRUE && TRUE) == False
!(TRUE && FALSE) == True

!(TRUE || TRUE) == False
!(FALSE || FALSE) == True

---------------------

ORDER of OPERATIONS

AND Before OR

(TRUE && TRUE) || (TRUE && FALSE) == True
(TRUE) || (FALSE) == True

TRUE && TRUE || FALSE == True
TRUE || FALSE == True

TRUE || TRUE && FALSE == TRUE
True || FALSE == TRUE

FALSE || FALSE && TRUE == False
FALSE || FALSE == False

--------------------

NEGATING

!(TRUE && TRUE) == False // 2 * (2 + 5) 
!(TRUE) == False // 2 * (7)

!(TRUE && TRUE) == False // 2 * (2 + 5)
!TRUE || !TRUE == False // (2 * 2) + (2 * 5)
FALSE || FALSE == False

-

!(FALSE || FALSE) == True
!(FALSE) == True

!FALSE && !FALSE == True
TRUE && TRUE == True
 */