using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct CalcStat
{
    public int m_nPow;
    public int m_nDef;
    public int m_nHP;

    public CalcStat(int a_nPow, int a_nDef, int a_nHP)
    {
        m_nPow = a_nPow; m_nDef = a_nDef; m_nHP = a_nHP;
    }

    public static CalcStat operator +(CalcStat a, CalcStat b)
    {
        return new CalcStat
            (a.m_nPow + b.m_nPow, 
             a.m_nDef + b.m_nDef, 
             a.m_nHP + b.m_nHP);
    }

    public static CalcStat operator -(CalcStat a, CalcStat b)
    {
        return new CalcStat
            (a.m_nPow - b.m_nPow,
             a.m_nDef - b.m_nDef,
             a.m_nHP - b.m_nHP);
    }
}

