// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным
//6 -> да 
//7 -> да 
//1 -> нет

Console.Clear();
Console.WriteLine("введите число от 1 до 7 по количеству дней недели: ");
int number = int.Parse(Console.ReadLine());
if ((number >= 1) && (number <= 5)) 
{ 
    Console.WriteLine("НЕТ");
}
    if ((number == 6) || (number == 7))
    { 
        Console.WriteLine("ДА");
    }    
        if ((number < 1) || (number > 7))
        {
            Console.WriteLine("введите число от 1 до 7 еще раз");
        }
