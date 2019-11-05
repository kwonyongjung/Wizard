using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Fire : Skill
{
    public Fire(eSkillType a_eType, Vec2 pos, Vec2 dir, char a_cRender)
                : base(a_eType, pos, dir, a_cRender) { }
    public override void Update(Unit u,float a_fDelta)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x + i, (int)u.m_vcPos.y + j, ' ');
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x - i, (int)u.m_vcPos.y - j, ' ');
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x - i, (int)u.m_vcPos.y + j, ' ');
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x + i, (int)u.m_vcPos.y - j, ' ');
            }
        }
        Console.BackgroundColor = ConsoleColor.Black;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x + i, (int)u.m_vcPos.y + j, ' ');
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x - i, (int)u.m_vcPos.y - j, ' ');
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x - i, (int)u.m_vcPos.y + j, ' ');
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Define.Render((int)u.m_vcPos.x + i, (int)u.m_vcPos.y - j, ' ');
            }
        }
    }
    public override void Interaction(Unit u)
    {
        if ((int)m_vcPos.x != (int)u.m_vcPos.x || (int)m_vcPos.y != (int)u.m_vcPos.y) { return; }
        if (bExist == false) { return; }
        bExist = false;
        u.activeZ = true;       
    }
}

