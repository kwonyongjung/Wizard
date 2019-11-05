using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnitTable : ICalcStat
{
    public int m_nID;
    public string m_sName;
    public int m_nPow;
    public int m_nDef;
    public int m_nHP;
    public Vec2 m_vcPos;
    public Vec2 m_vcDir;
    public float m_fSpeed;
    public char m_cRender;

    public UnitTable(int a_nID, string a_sName, int a_nPow, int a_nDef,
                     int a_nHP, float a_fSpeed, char a_cRender)
    {
        m_nID       = a_nID;
        m_sName     = a_sName;
        m_nPow      = a_nPow;
        m_nDef      = a_nDef;
        m_nHP       = a_nHP;
        m_fSpeed    = a_fSpeed;
        m_cRender   = a_cRender;
    }

    public CalcStat GetCalcStat() => new CalcStat(m_nPow, m_nDef, m_nHP);
}

