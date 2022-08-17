/*
Решение в группах задач:
Задача 1: Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int DigitsNum(int Num)
{
    if(Num==0) return 1;
    int answer=0;
    while(Num>0)
    {
        Num=Num/10;
        answer++;
    }

    return answer;
}

int digits=Prompt("eneter your number: ");
System.Console.WriteLine($" digits quantity in your number is: {DigitsNum(digits)}");
