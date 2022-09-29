Console.WriteLine("Enter a number between 1 and 100.");

int num1 = int.Parse(Console.ReadLine());

if (num1 > 60 && num1 % 2 == 0)
{ Console.WriteLine("Even and greater than 60"); }


else if (num1 > 60 && num1 % 2 != 0)
{ Console.WriteLine("Odd and greater than 60"); }


else if (num1 < 60 && num1 % 2 != 0)
{ Console.WriteLine("Odd and less than 60"); }

else if (num1 < 25 && num1 > 1 && num1 % 2 == 0)
{ Console.WriteLine("Even and less than 25"); }

else if (num1 > 25 && num1 < 61 && num1 % 2 == 0)
{ Console.WriteLine("Even and between 26 and 60 inclusive"); }

else if (num1 < 1 || num1 > 100)

{ Console.WriteLine("Sorry, your entry does not meet the criteria."); }






