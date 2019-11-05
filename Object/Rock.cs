using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rock : Object
{
    eDir LastMove;
    public Rock(eObjectType a_eType, int a_nX, int a_nY, char a_cRender) : base(a_eType, a_nX, a_nY, a_cRender) { }

    public override void Interaction(Unit u)
    {
        if (bExist == false) { return; }
        if (m_nX != (int)u.m_vcPos.x || m_nY != (int)u.m_vcPos.y) { return; }
        if (u.LastMove == eDir.None) { return; }

        switch (u.LastMove)
        {
            case eDir.Left: LastMove = eDir.Left; m_nX--; break;
            case eDir.Top: LastMove = eDir.Top; m_nY--; break;
            case eDir.Right: LastMove = eDir.Right; m_nX++; break;
            case eDir.Bottom: LastMove = eDir.Bottom; m_nY++; break;
        }

        Render();
    }
    public void InteractionWall(Object o)
    {
        if (bExist == false) { return; }
        if (m_nX != (int)o.m_nX || m_nY != (int)o.m_nY) { return; }
        if(o.m_eType == eObjectType.Wall)
        {
            switch (LastMove)
            {
                case eDir.Left: m_nX++; break;
                case eDir.Top: m_nY++; break;
                case eDir.Right: m_nX--; break;
                case eDir.Bottom: m_nY--; break;
            }
        }
        if (o.m_eType == eObjectType.WaterWall || o.m_eType == eObjectType.FireWall)
        {
            o.bExist = false;
            bExist = false;
        }
        Console.SetCursorPosition(o.m_nX, o.m_nY);
        Console.Write(' ');
        Render();
    }
}

