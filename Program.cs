string[] array = {"Hello", "World", "I", "Love", "You"}; //Задаём массив
PrintSortArray(array); // Метод для вывода массива со словами меньше четырёх символов

void PrintSortArray (string[] arr)
{
    int sortArrLength = 0;  // Сюда запишем количество строк с длиной меньше 4 символов
    int sortIndex = 0;   // Переменная для индексации отсортированного массива
    int wordLength = 4;  // Условие для сортировки, длина символов строк меньше 4
    for (int i = 0; i<arr.Length; i++)  // Ищем строки короче 4 символов
    {
        if(arr[i].Length < wordLength) sortArrLength++; 
    }
    if(sortArrLength > 0)  // Если есть строки короче 4 символов, то создаём массив из таких строк и выводим его в консоль
    {
        string[] sortArr = new string[sortArrLength];
    
        for(int i = 0; i<arr.Length;i++)
        {
            if(arr[i].Length < wordLength)
            {
                sortArr[sortIndex] = arr[i];
                sortIndex++;
            }
        } 
        string s = string.Join("\", \"" , sortArr);
        Console.Write("[\"");
        Console.Write(s);
        Console.Write("\"]");
    }
    if(sortArrLength == 0) // Если нет строк короче 4 символов, то выводим в консоль []
    {
        Console.Write("[]");
    }
} 