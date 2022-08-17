
/*
Задача 3: Напишите программу, которая выводит 
массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int[] RandomArr()
{
    int[] answer=new int[8];
    for(int i=0;i<answer.Length;i++) {answer[i]=new Random().Next(0,2);}
    return answer;
}

int[] array=RandomArr();
Console.Write ($"array of random values 0 or 1 is:[");
for(int i=0;i<array.Length;i++) 
{
    
    Console.Write ($" {array[i]}");

}
Console.Write ($"]");
