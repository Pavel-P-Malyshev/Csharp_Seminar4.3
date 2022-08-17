/*
Задача 1: Напишите программу, которая принимает 
на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int SumA(int A)
{
    int answer=0;
    for(int i=1;i<=A;i++) {answer+=i;}
    return answer;

}

double GaussSumA(int A)
{
    return (A+1)*(A/2.0);
}

int a=Prompt("eneter A: ");
while(a<1) {a=Prompt("A cannot be less than 1, enter correct A: ");}
System.Console.WriteLine($"sum of natuaral numbers between 1 and A is: {SumA(a)}");
System.Console.WriteLine($"Gauss sum of natuaral numbers between 1 and A is: {GaussSumA(a)}");