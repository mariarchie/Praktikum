int[] A = new int[10];
int[] B = new int[10];
int index = 0;

// Заполняем массив
while (index < 10)
{
    A[index] = new Random().Next(10,100); //[10,99]
    index++;
}

index = 0;

// Печатаем массив

while (index<10)
{
    Console.WriteLine(A[index]);
    index++;
}
Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания 
int currentEl = A[0];
Console.WriteLine(currentEl);
while (index<10)
{
    if(A[index]>currentEl)
    {
        //Заполнение массива B
        B[index] = A[index];
        Console.WriteLine(B[index]);
        currentEl = A[index];
    }
    index++;
}
