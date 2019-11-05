using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ObjectTable : ICalcStat
{
    public int m_nPow;
    public int m_nDef;
    public int m_nHP;
    public eObjectType m_eType;
    public ObjectTable(eObjectType a_eType, int a_nPow, int a_nDef, int a_nHP)
    {
        m_nPow      = a_nPow;
        m_nDef      = a_nDef;
        m_nHP       = a_nHP;
        m_eType     = a_eType;
    }

    public CalcStat GetCalcStat() => new CalcStat(m_nPow, m_nDef, m_nHP);
}
