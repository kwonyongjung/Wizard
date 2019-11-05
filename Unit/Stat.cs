using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Stat
{
    public int m_nHP;
    public int m_nPow;
    public int m_nDef;

    public Stat(int a_nPow, int a_nDef, int a_nHP)
    {
        m_nPow  = a_nPow;
        m_nDef  = a_nDef;
        m_nHP = a_nHP;
    }

    public void ApplyUnitTb(UnitTable a_refTb)
    {
        m_nPow = a_refTb.m_nPow;
        m_nDef = a_refTb.m_nDef;
        m_nHP = a_refTb.m_nHP;
    }

    public void ApplyObjTb(ObjectTable a_refTb)
    {
        m_nPow = a_refTb.m_nPow;
        m_nDef = a_refTb.m_nDef;
        m_nHP = a_refTb.m_nHP;
    }

    public void ApplyCalcStat(CalcStat a_stat)
    {
        m_nPow += a_stat.m_nPow;
        m_nDef += a_stat.m_nDef;
        m_nHP += a_stat.m_nHP;
    }

    public static Stat operator +(Stat a, Stat b)
    {
        return new Stat(a.m_nPow + b.m_nPow, a.m_nDef + b.m_nDef, a.m_nHP + b.m_nHP);
    }

    public static Stat operator -(Stat a, Stat b)
    {
        return new Stat(a.m_nPow - b.m_nPow, a.m_nDef - b.m_nDef, a.m_nHP - b.m_nHP);
    }
}
