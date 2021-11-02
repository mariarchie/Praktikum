// Задача №1
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные

int[] A = new int[10];
int[] B = new int[10]; // условие 1
int[] C = new int[10]; // условие 2
int[] D = new int[10]; // условие 3
int index = 0;

// Заполняем массив A
while (index < 10)
{
    A[index] = new Random().Next(10, 100); //[10,99]
    index++;
}

index = 0;

// Печатаем массив
Console.WriteLine("Массив A");
while (index < 10)
{
    Console.WriteLine(A[index]);
    index++;
}


Console.WriteLine();
Console.WriteLine("Массив B");
// Исключение элементов нарушения возрастания и заполнение массива B
index = 1;
int currentEl = A[0];
Console.WriteLine(currentEl);
while (index < 10)
{
    if (A[index] > currentEl)
    {
        B[index] = A[index];
        Console.WriteLine(B[index]);
        currentEl = A[index];
    }
    index++;
}

Console.WriteLine();
//Поиск среднего арифметического элементов массива А
int summ = 0;
for (index = 0; index < A.Length; index++)
    summ += A[index];
int mid = summ / A.Length;

Console.WriteLine();
Console.WriteLine("Массив С");
//Заполнение и вывод массива С элементами, меньшими или равными среднего арифметического элементов массива А
index = 0;
while (index < 10)
{
    if (A[index] <= mid)
    {
        C[index] = A[index];
        Console.WriteLine(C[index]);
    }
    index++;
}

Console.WriteLine();
Console.WriteLine("Массив D");
//Заполнение и вывод массива D нечетными элементами массива A
index = 0;
while (index < 10)
{
    if (A[index] % 2 == 1)
    {
        D[index] = A[index];
        Console.WriteLine(D[index]);
    }
    index++;
}

