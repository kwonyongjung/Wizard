using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SkillTable : ICalcStat
{
    public int m_nPow;
    public int m_nDef;
    public int m_nHP;
    public int m_nRange;
    public eSkillType m_eType;
    public SkillTable(eSkillType a_eType, int a_nPow, int a_nDef, int a_nHP, int a_nRange)
    {
        m_nPow = a_nPow;
        m_nDef = a_nDef;
        m_nHP = a_nHP;
        m_eType = a_eType;
        m_nRange = a_nRange;
    }

    public CalcStat GetCalcStat() => new CalcStat(m_nPow, m_nDef, m_nHP);
}
