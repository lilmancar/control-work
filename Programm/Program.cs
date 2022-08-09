string[] array1 = new string[5] {"Hello", "2", "world", ":-)", "Lev"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Приветствую! ");
Console.WriteLine("Это программа , которая из имеющегося массива строк формирует новый массив из строк, ");
Console.WriteLine("длина которых меньше, либо равна 3 символам. ");
Console.WriteLine("Приветствую! ");
SecondArrayWithIF(array1, array2);
PrintArray(array2);