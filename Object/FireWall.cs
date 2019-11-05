using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FireWall : Map
{
    public FireWall(eObjectType a_eType, int a_nX, int a_nY, char a_cRender) : base(a_eType, a_nX, a_nY, a_cRender) { }

    public override void Render()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Render();
        Console.ForegroundColor = ConsoleColor.White;
    }

    public override void Interaction(Unit u)
    {
        if (m_nX != (int)u.m_vcPos.x || m_nY != (int)u.m_vcPos.y) { return; }
        u.ApplyWall(m_eType);
    }
}
