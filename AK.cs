using System;

int userNumInput = 0;
int userOpInput;
int sum = 0;
int subtraction = 0;
int product = 1;
float quotient = 1;

Console.WriteLine("How many numbers do you require to complete your calculation?");
userNumInput = Convert.ToInt32(Console.ReadLine());

int[] numberinput = new int[userNumInput];

Console.Clear();

for (int i = 0; i < userNumInput; i++)
{
    Console.Write("Enter Number: ");
    numberinput[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

Console.WriteLine("Please choose the corresponding numeral assigned to the operator for your calculation.\n 1. +(addition)\n 2. -(subtraction)\n 3. *(multiplication)\n 4. /(divison)\n");
userOpInput = Convert.ToInt32(Console.ReadLine());

if (userOpInput == 1)
{
    for (int i = 0; i < numberinput.Length; i++)
    {
        sum += numberinput[i];
    }
    Console.WriteLine("The sum is: " + sum);
} 
else if(userOpInput == 2)
{
    subtraction = numberinput[0];
    for (int i = 1; i < numberinput.Length; i++)
    {
        subtraction -= numberinput[i];
    }
    Console.WriteLine("The result of subtraction is: " + subtraction);
} 
else if(userOpInput == 3)
{
    for (int i = 0; i < numberinput.Length; i++)
    {
        product *= numberinput[i];
    }
    Console.WriteLine("The product is: " + product);
} 
else if (userOpInput == 4)
{
    quotient = numberinput[0];
    for (int i = 1; i < numberinput.Length; i++)
    {
        quotient /= numberinput[i];
    }
    Console.WriteLine("The quotient is: " + quotient);
} 
else
{
    Console.WriteLine("You did not choose a valid number");
}

Console.ReadKey();