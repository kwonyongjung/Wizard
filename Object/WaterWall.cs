using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WaterWall : Object
{
    public WaterWall(eObjectType a_eType, int a_nX, int a_nY, char a_cRender) : base(a_eType, a_nX, a_nY, a_cRender) { }

    public override void Render()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        base.Render();
        Console.BackgroundColor = ConsoleColor.Black;
    }

   
}
