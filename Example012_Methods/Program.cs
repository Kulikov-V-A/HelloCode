// Вид 1
// void Method()
// {
//     Console.WriteLine("Автор ...");
// }
//Method();


//Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
//Method2(msg: "Текст сообщения");


// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21(msg: "Текст", count: 4);       //можно указывать какому аргументу, 
                                        //какое значение мы хотим присвоить

//Method21(count: 4, msg: "новый текст"); //именованные аргументы можно менять местами


//Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
//Console.WriteLine(year);


//Вид 4

// string Method4(int count, string text)                   // возвращаем строку
// {
//     int i = 0;
//     //string result = "";                               //вариант подготовленной пустой строки
//     string result = String.Empty;                       //второй вариант
//     while (i < count)
//     {
//         i++;
//         result = result + text;
//     }
//     return result;
// }

//Метод для for

// string Method4(int count, string text)                 
// {
    
//     string result = String.Empty;                       
//     for(int i = 0; i < count; i++)
//     {   
//         result = result + text;
//     }
//     return result;
// } 


// string res = Method4(10, "z");
// Console.WriteLine(res);


//Использование цикла в цикле

//Задача - вывод таблицы умножения на экран

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
// Console.WriteLine();
// }


// Задача. Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к", заменить большими "К", а большие "С", заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//              + "ежели бы вас послали вместо нашего милого Винценгероде,"
//              + "вы бы взяли приступом согласие прусского короля. "
//              + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"                      Пример:
// //             012345                       - порядок символов текста
// // s[3] = s                                 - в данном случае символ 3 это буква s

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;           //- инициализация пустой строки


//     int length = text.Length;               //- получение длины строки
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
    
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);



//Упорядочить массив (алгоритм сортировки методом выбора, сортировки методом минимакса)

/* 
Функции в программировании 
1. Найти позицию минимального элемента в неотсортированной части массива
2. Произвести обмен этого значения со значением первой неотсортированной позиции
3. Повторять пока есть неотсортированные элементы
*/

// int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

//Сортировка в обратном порядке (от максимума к минимуму)

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);












