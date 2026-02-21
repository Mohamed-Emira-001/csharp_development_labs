// See https://aka.ms/new-console-template for more information
///////Console Calulator///////////
//Welcome Message
Console.WriteLine("Hello");
Console.WriteLine("What is Your Name ?");
//Take the User_Name (Input) 
string userInput = Console.ReadLine();
Console.WriteLine($"Welcome {userInput}\n Okay Choose Your First Number");
//Take the firstNumber (Input)
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine($"First number is {num1}\n Now Choose Your Second Number");
//Take the secondNumber (Input)
int num2 = int.Parse(Console.ReadLine());
//Take the CHOOSEN arthimitic Operation (* / + -)
Console.WriteLine($"Second number is {num2}\n Now Choose Your Second Number\n Now choose your arthimtic operation whether is (* / + -)");
char arhtOperator = char.Parse(Console.ReadLine());
Console.WriteLine($"Your Choosen arthimatic Operator is {arhtOperator}\n");
//Intalize a variable
int result;
/////* The Calculation by making if-condition */////

if (arhtOperator == '*') // if the user chooses *
{
    result = num1 * num2;
    Console.WriteLine(result);
}else if (arhtOperator == '/') //if the user chooses /
{
    result = num1 / num2;
    Console.WriteLine(result);

    Console.WriteLine(result);
}else if (arhtOperator == '+') // if the user chooses +
{
    result = num1 + num2;
    Console.WriteLine(result);
}else{
    result = num1 - num2; //if the user chooses -
    Console.WriteLine(result);
     }

//End Message
Console.WriteLine("BYE BYE!!");