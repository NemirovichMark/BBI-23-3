using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4

  abstract class Game
{
    public abstract void StartGame();
}
class NumberGame : Game
{
    public override void StartGame()
    {
     Console.WriteLine("Давайте сыграем в игру. Введите диапазон чисел (от и до):");

     int from = Convert.ToInt32(Console.ReadLine());
     int to = Convert.ToInt32(Console.ReadLine());

        if (to - from < 2  from < 0  to < 0)
        {
         Console.WriteLine("Ошибка. Проверьте условия.");
            return;
        }



    }
}

