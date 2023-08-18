namespace ConsoleApp2
{
    internal class Program
    {
        //static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            //[generate fibonacci number]
            //Console.WriteLine("please provide input value");
            //int count = Int32.Parse(Console.ReadLine());
            //Console.Write(p1 + " " + p2);
            /////or method use
            //Fibonacci(count - 2);
            //for (int i = 2; i < count; i++)
            //{
            //    p3 = p1 + p2;
            //    Console.Write(" " + p3);
            //    p1 = p2;
            //    p2 = p3;
            //}


            /////Factorial Number
            //Console.WriteLine("Please provide factorial number.");
            //int factorialNum =Int32.Parse(Console.ReadLine());
            //int factResult = 1;
            //for (int i = 1; i <= factorialNum; i++)
            //{
            //    factResult = factResult * i;
            //}
            ////Or
            //for (int i =factorialNum; i>=factorialNum; i--)
            //{
            //    factResult = factResult * i;
            //}
            //Console.WriteLine("{0}! is {1}",factorialNum,factResult);

            ////Sum of digits of a given number
            //Console.WriteLine("Please provide input number");
            //int inputNumber= Int32.Parse(Console.ReadLine());
            //int backupValue = inputNumber;
            //int sum = 0, remainder = 0;
            //while (inputNumber != 0)
            //{
            //    remainder = inputNumber % 10;
            //    sum += remainder;
            //    inputNumber=inputNumber / 10;
            //}
            //Console.WriteLine("sum of {0} is {1}",backupValue,sum);



            /////Celsius to Fahrenheit Conversion && Fahrenheit to Celsius Conversion

            //TemperatureConverter temp=new TemperatureConverter();
            //Console.WriteLine("Please provide celsius temp:");
            //string val1=Console.ReadLine();
            //double fahrenheit=temp.CelsiusToFahrenheit(val1);
            //Console.WriteLine($"The value of {val1} celsius is {fahrenheit}fahrenheit");

            //Console.WriteLine("Please provide fahrenheit temp");
            //string val2=Console.ReadLine();
            //double celsius=temp.FahrenheitToCelsius(val2);
            //Console.WriteLine($"The value of {val2} fahrenheit is {celsius}celsius");



            ////sum of natural numbers && Even numbers && odd numbers
            //Console.WriteLine("Please provide sum of natural numbers count:");
            //int count=Int32.Parse(Console.ReadLine());
            //int sum = 0;
            ////sum of natural numbers


            //for (int i = 1; i <= count; i++)
            //{

            //    sum = sum + i;
            //}
            //Console.WriteLine($"sum of {count} number is sum {sum}");

            //// sum of even numbers
            //for (int i = 1; i <= count; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum=sum+i;
            //    }
            //}
            //Console.WriteLine($"sum of {count} even number is sum {sum}");


            //// sum of odd numbers
            //for (int i = 1; i <= count; i++)
            //{
            //    if(i%2 != 0)
            //    {
            //        sum=sum+i;
            //    }
            //}
            //Console.WriteLine($"sum of  {count} odd number is sum {sum}");


            //Finding Factors of a given number

            //Console.WriteLine("Please provide input number");
            //int input = Int32.Parse(Console.ReadLine());
            ////if I want to sum those factors
            //int sum = 0;
            //for (int i = 1; i <=input; i++)
            //{
            //    if (input % i == 0)
            //    {
            //        Console.WriteLine($"{i} is a factor of {input}");
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"sum of factors of {input} is {sum}");


            //Swaping two numbers with temporary variables

            //int a = 5, b = 10, temp;
            //Console.WriteLine($"values before swaping a: {a} && b: {b}");
            //temp = a;
            //a = b;
            //b= temp;
            //Console.WriteLine($"values after swaping a: {a} && b: {b}");

            //Swaping two numbers without temporary variables

            //int a = 5, b = 10;
            //Console.WriteLine($"values before swaping a: {a} && b: {b}");

            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine($"values after swaping a: {a} && b: {b}");


            //the program to reverse a number
            //Console.WriteLine("Please provide input number");
            //int input = Int32.Parse(Console.ReadLine());
            //int remainder, reverse = 0;
            //while (input > 0)
            //{
            //    remainder = input % 10;
            //    reverse = reverse * 10 + remainder;
            //    input = input / 10;
            //}
            //Console.WriteLine($"Reverse number is {reverse}");


            //Program to check palindrome number
            //Console.WriteLine("Please provide input number");
            //int input=Int32.Parse(Console.ReadLine());
            //int backup = input;
            //int remainder, reverse = 0;
            //while (input > 0)
            //{
            //    remainder = input % 10;
            //    reverse = reverse * 10 + remainder;
            //    input=input / 10;
            //}
            //if (backup==reverse)
            //{
            //    Console.WriteLine($"{backup} is palindrome number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{backup} is not palindrome number.");
            //}
        }

        //private static void Fibonacci(int count)
        //{
        //    if (count > 0)
        //    {
        //        p3 = p1 + p2;
        //        Console.Write(" " + p3);
        //        p1 = p2;
        //        p2 = p3;
        //        Fibonacci(count - 1);
        //    }
        //}
    }
}