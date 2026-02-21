//// Do you know me well ?? ////
using System.ComponentModel.Design;

string[] questions ={"What is my name?","What is my age?","Where am i from?"};
string[] answers ={"emira","youssef","yassin","20","27","32","morroco","italy","egypt"};

//Intalize Score 
int score = 0;
Console.WriteLine("Welcome to (Do you know me Program)\nChoose the Correct Answer");
//First Question
Console.WriteLine($"First Question:{questions[0]}\n A:{answers[0]}\n B:{answers[1]}\n C:{answers[2]}");
string user_answer1 =Console.ReadLine();
//Second Question
Console.WriteLine($"Second Question:{questions[1]}\n A:{answers[3]}\n B:{answers[4]}\n C:{answers[5]}");
string user_answer2 = Console.ReadLine();
//Third Question
Console.WriteLine($"Third Question:{questions[2]}\n A:{answers[6]}\n B:{answers[7]}\n C:{answers[8]}");
string user_answer3 = Console.ReadLine();


//validate the answers
if (user_answer1 == answers[0])
{
    score++;
    Console.WriteLine($"Your answer is correct your score is {score}");
}
else if (user_answer2 == answers[4])
{
    score++;
    Console.WriteLine($"Your answer is correct your score is {score}");
}
else if (user_answer3 == answers[8])
{
    score++;
    Console.WriteLine($"Your answer is correct your score is {score}");
}
else
{
    score--;
    Console.WriteLine($"Your answer is wrong your score is {score}");
}
