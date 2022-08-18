
/*- ***Распечатать последовательность, элементы которой повторяются столько раз, чему равно значение элемента, например:

 [1,2,2,3,3,3,4,4,4,4,5,5,5,5,5]

 */

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int[] InsertedArray(int N)
{
    double size=(N+1)*(N/2.0);  //размер массива равен сумме элементов от 1 до N.
    //Console.WriteLine($"size={size}");
    int[] answer=new int[(int)size];
     
    int inner_idx=0;
    int outer_idx=0;
    int places=0;
    int curval=0;

    while(outer_idx<N)
    {
        
        curval=outer_idx+1;
        places=curval;

        for (inner_idx = 0; inner_idx < places; inner_idx++)
        {
            //стартовый индекс для записи нового блока чисел отсчитываем от суммы элементов от 1 до N-1,
            answer[((int) (curval*((curval-1)/2.0)))+inner_idx]=curval;
           
           
           /*  Console.WriteLine($" index {(int) (curval*((curval-1)/2.0))}");

            Console.WriteLine($" inner {inner_idx}");
           Console.WriteLine($" outer {outer_idx}");

            Console.WriteLine($"value={curval}");*/

        }
        outer_idx++;
    }
    
    return answer;
}

int n=Prompt("Enter value: ");
int[] array=InsertedArray(n);
Console.Write ($"array of cycled values  is:[");
for(int i=0;i<array.Length;i++) 
{
    
    Console.Write ($" {array[i]}");

}
Console.Write ($"]");
