using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO!");
            Console.WriteLine("Hello How are you?"); //This is the syntax for output in C#.
            Console.Write("This is"); // Console.WriteLine prints the output on the existing line and appends a new line after it.
            Console.Write(" C# tutorial");//while Console.Write prints the output but does not append a new line after it.
            Console.Write(" for students"); //hence Console.Write prints the next output in the same line.

            //now here are some examples on the data types in C#

            Console.WriteLine('b'); //this is a  character data type which is encoded with single cote because it is a literal.
            Console.WriteLine("Hello"); //this is a string data type which is encoded with double cote because it is a string.
            Console.WriteLine(5); //this is an integer data type which is encoded with no cotes because it is a number.
            Console.WriteLine(10.56790754m); //this is a decimal data type(floating type) which is used when when there is 28-29 digits.(m for decimal)
            Console.WriteLine(5.5f); //this is a float data type which is used when there is 6-9 digits.( for float)
            Console.WriteLine(5.5); //this is a double data type(floating type) which is used when there is 15-17 digits.(nothing or d for double)
            Console.WriteLine(true); //this is a boolean data type which is used when there is only two values true or false.(for true)
            Console.WriteLine(false); //this is a boolean data type which is used when there is only two values true or false.(for false)

            //now we will learn about the variables in C#

            int a; //here we created a new variable of type int with the name a.From now on this variable can only hold integer values
            a = 5; //here we assigned the value 5 to the variable a.this is a set operator
            Console.WriteLine(a); //this will print the value of a which is 5.This is a get operator.
            a = 10; //here we assigned the value 10 to the variable a.this is reassigning the variale.
            Console.WriteLine(a); //this will print the value of a which is 10.
            string useroption = "yes";
            Console.WriteLine(useroption); // assigning and retriving the valus can also be done in one line. here we have used string data type.

            //implicitely typing the variable.
            //it should always be initialized to use in a single line.

            var b = 5; //here we created a new variable of type int with the name b and assigned the value 5 to it. compiler will automatically detect the type of the variable without exactly mentoning it in the code.
            Console.WriteLine(b); //this will print the value of b which is 5. From now on the variable b can only hold integer values.

            //Now we will learn about the escape sequences in C#

            Console.WriteLine("Hello \n How are you?"); //this will print Hello in the first line and How are you? in the second line.
            Console.WriteLine("Hello \t How are you?"); //this will print Hello in the first line and How are you? with a tab space.
            Console.WriteLine("Hello \"world\""); //this will print Hello "world" with double quotes.
            Console.WriteLine("c:\\source\\repos"); //this will print c:\source\repos with a single backslash.

            //Here is an example of character escape sequence.

            Console.WriteLine("Generating invoice for customer \"Contoso crop\" ...\n");
            Console.WriteLine("Invoice number: 123456\t\tComplete!");
            Console.WriteLine("Invoice date: 01/01/2023\tTotal amount: $100.00");
            Console.WriteLine("\nOutput Directory: C:\\Invoices\\2023\\01\\01");

            //Verbatim string literal

            Console.WriteLine(@"        Hello!..
             (who are you?)"); //A verbatim string is a type of string in C# that keeps the text exactly how you write it — including spaces, new lines, and backslashes.

            //unicode escape character

            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");//we  can also add encoded characters in literal strings using the \u escape sequence, then a four-character code representing some character in Unicode (UTF-16).

            //string concatination 

            string firstname = "John";
            string username = "Doe";
            Console.WriteLine(username + " " + firstname); //this will print John Doe with a space in between.
            Console.WriteLine("Hello " + firstname + " " + username); //this will print Hello John Doe with a space in between.

            //String Interpolation

            int version = 11;
            string updateText = "Update your windows to";
            String message = $"hello ! {updateText} {version}";
            Console.WriteLine(message); //this will print hello ! Update your windows to 11 with a space in between.

            //Combine verbatim literals and string interpolation
            string projectName = "Csharp Syntax";
            Console.WriteLine($@"c:\{projectName}\source\repos"); //this will print c:\Csharp Syntax\source\repos with a single backslash.

            //basic math operations

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            //code to cast results of integer division
            int first = 7;
            int second = 5;
            decimal q = (decimal)first / (decimal)second;
            Console.WriteLine(q);

            //code to determine the remainder after integer division
            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");


            //order of operations
            //The order of operations in C# is the same as in mathematics. The order of operations is as follows:PEMDAS
            //1. Parentheses
            //2. Exponents
            //3. Multiplication and Division
            //4. Addition and Subtraction
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            //increment and decrement operators. if you use the operator before the value as in ++value, then the increment will happen before the value is retrieved. 
            //Likewise, value++ will increment the value after the value has been retrieved.
            int value3 = 0;     // value is now 0.
            value3 = value3 + 5; // value is now 5.
            value3 += 5;        // value is now 10.

            //In other way,
            int value4 = 0;     // value is now 0.
            value4 = value4 + 1; // value is now 1.
            value4++;           // value is now 2.

            //Challenge: Calculate Celsius given the current temperature in Fahrenheit
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32) * 5 / 9m;
            Console.WriteLine("the temperature is " + celsius + " Celsius");

        }
    }
}
