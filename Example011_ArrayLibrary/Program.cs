/*
void FillArray(int[] collection)  //Создание метода для заполнения массива данными, collection - это аргумент 
{
    int length = collection.Length;  //Вводим длину массива
    int index = 0;                   //Установим индекс в нулевое положение
    while (index < length)           //Создаем цикл если индекс искомого элемента меньше длины массива
    {
        collection[index] = new Random().Next(1, 10);     //Ложим в ячейку индекса случайное число и так по кругу
        index++;                     //Увеличения индекса на 1
        //index = index + 1;
    }
}

void PrintArray(int[] col)                 //Метод, который будет печатать массив на экран, col - это аргумент 
{
    int count = col.Length;                //Связывание длиным массива col.Length с количеством элементов count
    int position = 0;                      //По сути тоже самое что и индекс       
    while (position < count)               
    {
        Console.WriteLine(col[position]);  //Вывод значения текущего элемента
        position++;
    }
}

int [] array = new int[10]; //Создан новый массив в котором будет 10 элементов

FillArray(array);                          //Вызываем следующий метод FillArray, где array - наименование массива
PrintArray(array);                         //Вводим метод PrintArray - для печати
*/

//Нахождение нужного нам элемента в массиве с использованием метода

void FillArray(int[] collection)  //Создание метода для заполнения массива данными, collection - это аргумент 
{
    int length = collection.Length;  //Вводим длину массива
    int index = 0;                   //Установим индекс в нулевое положение
    while (index < length)           //Создаем цикл если индекс искомого элемента меньше длины массива
    {
        collection[index] = new Random().Next(1, 10);     //Ложим в ячейку индекса случайное число и так по кругу
        index++;                     //Увеличения индекса на 1
        //index = index + 1;
    }
}

void PrintArray(int[] col)                 //Метод, который будет печатать массив на экран, col - это аргумент 
{
    int count = col.Length;                //Связывание длиным массива col.Length с количеством элементов count
    int position = 0;                      //По сути тоже самое что и индекс       
    while (position < count)               
    {
        Console.WriteLine(col[position]);  //Вывод значения текущего элемента
        position++;
    }
}
//Создаем метод отличный от void, название Indexof, в качестве аргумента приходит массив []collection, и элемент find
int Indexof(int []collection, int find)
{
    int count = collection.Length;         //Определяем количество элементов count
    int index = 0;
    int position = -1;                      //Сохранение найденной позиции совпавшей с find
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;                       //Выводим позицию из цикла
}

int [] array = new int[10]; //Создан новый массив в котором будет 10 элементов

FillArray(array);                          //Вызываем следующий метод FillArray, где array - наименование массива
array[4] = 4;                              //Принудительно добавили на 4 и 6 позиции массива array числа 4
array[6] = 4;
PrintArray(array);                         //Вводим метод PrintArray - для печати
Console.WriteLine();
//Определяем переменную pos - туда определяем результат работы метода Indexof, в качестве аргумента массим array, ищем 4
int pos = Indexof(array, 444);
Console.WriteLine(pos);


