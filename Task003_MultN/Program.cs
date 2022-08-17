/*
Задача 2: Напишите программу, которая 
принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int MultN(int N)
{
    int answer=1;
    for(int i=1;i<=N;i++) {answer*=i;}
    return answer;
}

int n=Prompt("enter your number:");
while(n<1) {n=Prompt("Number cannot be less than 1, enter new number:");}
Console.WriteLine($"The multile of natural numbers between 1 and N is:  {MultN(n)}");


