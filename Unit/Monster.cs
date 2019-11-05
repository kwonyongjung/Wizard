using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Monster : Unit
{
    public Monster(int a_nID, Vec2 a_vPos, Vec2 a_vDir) : base(a_nID, a_vPos, a_vDir) { }

    public override void Interaction(Unit u)
    {
        if (bExist == false) { return; }
        if ((int)m_vcPos.x != (int)u.m_vcPos.x || (int)m_vcPos.y != (int)u.m_vcPos.y) { return; }
        if (u.LastMove == eDir.None) { return; }

        eDir rollBack = eDir.None;

        switch (u.LastMove)
        {
            case eDir.Left: rollBack = eDir.Right; break;
            case eDir.Top: rollBack = eDir.Bottom; break;
            case eDir.Right: rollBack = eDir.Left; break;
            case eDir.Bottom: rollBack = eDir.Top; break;
        }

        u.Move(rollBack);
        u.Render();

        Render();
    }
}

