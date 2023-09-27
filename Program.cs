using System.Security.Cryptography;
using System.Threading.Channels;

static void gess_game()
{
    Random random_num = new Random();
    int random = random_num.Next(0, 100);

    int number = Convert.ToInt32(Console.ReadLine());
    bool flag = true;
    while (flag)
    {
        //ctrl + k + d
        //ctrl + k + d
        //ctrl + k + d
        //ctrl + k + d
        //ctrl + k + d
        //ctrl + k + d
        if (number == random)
        {
            Console.WriteLine("Поздравляю, вы угадали число");
            flag = false;
            break;
        }
        if (random < number)
        {
            Console.WriteLine("Загаданное число меньше вашего");
        }
        if (random > number)
        {
            Console.WriteLine("Загаданное число больше вашего");
        }
        number = Convert.ToInt32(Console.ReadLine());
    }
}
static void ymn()
{
    int[,] a = new int[11, 11];
    for (int rud = 1; rud < 11; rud++)
    {
        for (int mesto = 1; mesto < 11; mesto++)
        {
            a[rud, mesto] = rud * mesto;
            Console.Write(a[rud, mesto] + " ");
        }
        Console.WriteLine("");
    }

}


bool do_program = true;
Console.WriteLine("Добрый день");


Console.WriteLine("1- 'Угадай число'");
Console.WriteLine("2- 'Таблица умножения'");
Console.WriteLine("3- 'Вывод делителя числа'");
Console.WriteLine("4- 'Выход '");
Console.WriteLine("Выберите пункт: ");
int what_to_do = Convert.ToInt32(Console.ReadLine());
while (do_program)
{

    switch (what_to_do)
    {
        case 1:
            gess_game();
            break;
        case 2:
            ymn();
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("Досвидания, мыло и веревка ждут ");
            do_program = false;
            break;
        default:
            Console.WriteLine("Нет такой команды");
            break;

    }
    Console.WriteLine("1- 'Угадай число'");
    Console.WriteLine("2- 'Таблица умножения'");
    Console.WriteLine("3- 'Вывод делителя числа'");
    Console.WriteLine("4- 'Выход '");
    Console.WriteLine("Выберите пункт: ");
    what_to_do = Convert.ToInt32(Console.ReadLine());
}
/*Console.WriteLine("")*/
