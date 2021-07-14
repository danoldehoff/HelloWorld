using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are changing this number to demonstrate how to change public static variables from a different class
            Constants.Number = 4;
            Constants.Number++; // Same as Constants.Number = Constants.Number + 1;

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

            // Challenge: Start at 0, never reach 100, increment by 5
            for (int i = 0; i < 100; i += 5) // for(variable assignment ; conditional ; action to take after completing the loop)
            {
                FizzBuzz(i);
            }

            // Challenge: Start at 1, never go above 100, increment by 1
            for (int i = 1; i <= 100; i++) // for(variable assignment ; conditional ; action to take after completing the loop)
            {
                FizzBuzz(i);
            }


            int index = 0;
            while (index < 100) // while true, execute
            {
                FizzBuzz(index);
                index++;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("*");

            }



            Console.WriteLine("*");

        }


        // Fizz Buzz
        // If the number is divisible by both 3 and 5, Console.WriteLine("Fizz Buzz")
        // Else if the number is divisbile by 3, Console.WriteLine("Fizz")
        // Else if the number is divisible by 5, Console.WriteLine("Buzz")
        // Else, do nothing
        static void FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) //true
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
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}




//
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