//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
if ((number > 99) & (number <= 999))
{
    int xnumber = (number % 10);
    Console.WriteLine(xnumber);
}
        if(number <= 99) 
    {
            Console.WriteLine($"в введенном вами числе нет третьей цифры");
    }
            if ((number >= 1000) & (number < 10000))
            {
                int ynumber = (number % 100); ynumber /=10 ;
                Console.WriteLine(ynumber);
            }
                if ((number >= 10000) & (number < 100000))
                {
                    int znumber = (number % 1000); znumber /=100 ;
                    Console.WriteLine(znumber);
                }
                    if (number >= 100000)
                        Console.WriteLine($"STOP");
