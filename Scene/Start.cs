using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

class Start : Scene
{
    int y = 21;
    public override int Update(float a_fDelta)
    {
        if (eKey.Up.IsKeyDown() == true)
        {
            if (y == 21)
            {
                return 0;
            }
            y -= 1;
            Console.SetCursorPosition(80, y);
            Console.Write('←');
            Console.SetCursorPosition(80, y + 1);
            Console.Write(' ');
        }

        if (eKey.Down.IsKeyDown() == true)
        {
            if (y == 22)
            {
                return 0;
            }
            y += 1;
            Console.SetCursorPosition(80, y);
            Console.Write('←');
            Console.SetCursorPosition(80, y - 1);
            Console.Write(' ');
        }

        if (eKey.Enter.IsKeyDown() == true)
        {
            if (y == 21)
            {
                return 1;
            }
            else if(y == 22)
                return -1;
        }
        return 0;
    }
    public override void Render()
    {
        Console.SetCursorPosition(70, 20);
        Console.WriteLine("RPG");
        Console.SetCursorPosition(70, 21);
        Console.WriteLine("게임시작");
        Console.SetCursorPosition(70, 22);
        Console.WriteLine("게임종료");
    }
}
