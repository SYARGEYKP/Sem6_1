//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int[] GenerateArrayHand(int len) // объявлена функция ручного формирования массива
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Нажмите ENTER и введите число номер {i + 1} ");
        array[i] = InputInt(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array) // печатаем массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int PositiveNum(int[] number)
{
    int countPoitive = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
        {
            countPoitive++;
        }
    }
    return countPoitive;
}
int num = InputInt("Сколько чисел Вы хотите внести?");
int[] newArray = GenerateArrayHand(num);
PrintArray (newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чисел больше 0 в заданном списке равно: {PositiveNum (newArray)}");





