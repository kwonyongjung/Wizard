using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Skill
{
    public eSkillType m_eType;
    public Vec2 m_vcPos;
    public Vec2 m_vcDir;
    public char m_cRender;
    public bool bExist = true;
    public Skill(eSkillType a_eType, Vec2 pos, Vec2 dir, char a_cRender)
    {
        m_eType = a_eType;
        m_vcPos = pos;
        m_vcDir = dir;
        m_cRender = a_cRender;
    }

    virtual public void Update(Unit u, float Ticks)
    {
        RenderClear();

    }

    virtual public void RenderClear()
    {
        if (Define.ConsoleBoundaryCheck(m_vcPos) == false) { return; }
        Console.SetCursorPosition((int)m_vcPos.x, (int)m_vcPos.y);
        Console.Write(' ');
    }

    virtual public void Render()
    {
        if (bExist == false) { return; }
        if (Define.ConsoleBoundaryCheck(m_vcPos) == false) { return; }
        Console.SetCursorPosition((int)m_vcPos.x, (int)m_vcPos.y);
        Console.Write(m_cRender);
    }

    virtual public void Interaction(Unit u)
    {

    }
}
