﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ItemTable : ICalcStat
{
    public int m_nPow;
    public int m_nDef;
    public int m_nHP;
    public eItemType m_eType;
    public ItemTable(eItemType a_eType, int a_nPow, int a_nDef,
                       int a_nHP)
    {
        m_nPow = a_nPow;
        m_nDef = a_nDef;
        m_nHP = a_nHP;
        m_eType = a_eType;
    }

    static public CalcStat operator +(ItemTable a, ItemTable b)
    {
        return new CalcStat(
            a.m_nPow + b.m_nPow, a.m_nDef + b.m_nDef, a.m_nHP + b.m_nHP
            );
    }

    public CalcStat GetCalcStat() => new CalcStat(m_nPow, m_nDef, m_nHP);
}

