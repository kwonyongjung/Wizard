using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Unit
{
    Stat m_Stat;
    Stat m_NowStat;

    public int m_nUnitTbID;
    public string m_sName;
    public Vec2 m_vcPos;
    public Vec2 m_vcDir;
    public float m_fSpeed;
    public char m_cRender;
    public bool bExist = true;
    public bool activeA = false;
    public bool activeS = false;
    public bool activeD = false;
    public bool activeZ = false;
    public bool activeX = false;
    public bool activeC = false;

    List<ItemTable> m_liItem = new List<ItemTable>();

    public eDir LastMove = eDir.None;
    public Unit(int a_nID, Vec2 a_vPos, Vec2 a_vDir)
    {
        m_nUnitTbID = a_nID;

        UnitTable tb;
        if(TableManager.Ins().GetUnitTable(a_nID, out tb) == false)
        {
            Console.WriteLine("arg error or table data error");
        }
        m_sName = tb.m_sName;
        m_vcPos = a_vPos;
        m_vcDir = a_vDir;
        m_fSpeed = tb.m_fSpeed;
        m_cRender = tb.m_cRender;
        m_Stat.ApplyUnitTb(tb);
        m_NowStat = m_Stat;
    }

    public Stat MaxStat()
    {
        Stat temp = m_Stat;
        CalcStat Item = new CalcStat();

        for(int i = 0; i < m_liItem.Count; i++)
        {
            Item += m_liItem[i].GetCalcStat();
        }
        temp.ApplyCalcStat(Item);
        return temp;
    }

    public void ApplyItem(eItemType a_eType)
    {
        Stat now = MaxStat();

        int nHPGap = now.m_nHP - m_NowStat.m_nHP;

        if (TableManager.Ins().GetItemTable(a_eType, out ItemTable item) == false)
        {
            Console.WriteLine("arg error or check table");
            return;
        }
        m_liItem.Add(item);
        m_NowStat = MaxStat();
        m_NowStat.m_nHP -= nHPGap;
    }

    public void ApplyWall(eObjectType a_eType)
    {
        if(a_eType == eObjectType.FireWall)
        {
            if (TableManager.Ins().GetObjTable(a_eType, out ObjectTable map) == false)
            {
                Console.WriteLine("arg error or check table");
                return;
            }
            m_NowStat.m_nHP -= map.m_nHP;
        }
    }

    public void ActiveSkill(eSkillType a_eType, Unit m)
    {
        if (TableManager.Ins().GetSkillTable(a_eType, out SkillTable skill) == false)
        {
            Console.WriteLine("arg error or check table");
            return;
        }
        switch (a_eType)
        {
            case eSkillType.Fire:
                if ((m.m_vcPos.x > m_vcPos.x - skill.m_nRange && m.m_vcPos.x < m_vcPos.x + skill.m_nRange) &&
                    (m.m_vcPos.y > m_vcPos.y - skill.m_nRange && m.m_vcPos.y < m_vcPos.y + skill.m_nRange))
                    m.m_NowStat.m_nHP -= skill.m_nHP;
                break;
            case eSkillType.Ice:
                break;
            case eSkillType.Water:
                break;
            case eSkillType.Wind:
                break;
            case eSkillType.Earth:
                break;
            default:
                break;
        }
    }

    public void Info()
    {
        var stat = MaxStat();
        Console.WriteLine("{0} -----------------", m_sName);
        Console.WriteLine("HP : {0} / {1}", m_NowStat.m_nHP, stat.m_nHP);
        Console.WriteLine("Pow: {0} / {1}", m_NowStat.m_nPow, stat.m_nPow);
        Console.WriteLine("Def: {0} / {1}", m_NowStat.m_nDef, stat.m_nDef);
    }

    public void Update(eDir a_eDir)
    {
        RenderClear();
        Move(a_eDir);
        LastMove = a_eDir;
    }

    virtual public void Move(eDir a_eDir)
    {
        switch (a_eDir)
        {
            case eDir.Left:
                {
                    m_vcPos.x -= m_vcDir.x* m_fSpeed;
                }
                break;
            case eDir.Right:
                {
                    m_vcPos.x += m_vcDir.x * m_fSpeed;
                }
                break;
            case eDir.Top:
                {
                    m_vcPos.y -= m_vcDir.y * m_fSpeed;
                }

                break;
            case eDir.Bottom:
                {
                    m_vcPos.y += m_vcDir.y * m_fSpeed;
                }
                break;
        }
    }

    public void RenderClear()
    {
        if (Define.ConsoleBoundaryCheck(m_vcPos) == false) { return; }
        Console.SetCursorPosition((int)m_vcPos.x, (int)m_vcPos.y);
        Console.Write(' ');
    }

    public void Render()
    {
        if (bExist == false)
        {
            Console.SetCursorPosition((int)m_vcPos.x, (int)m_vcPos.y);
            Console.Write(' ');
            return;
        }
        if (m_NowStat.m_nHP < 0) { bExist = false; }
        if (Define.ConsoleBoundaryCheck(m_vcPos) == false) { return; }
        Console.SetCursorPosition((int)m_vcPos.x, (int)m_vcPos.y);
        Console.Write(m_cRender);
    }

    public virtual void Interaction(Unit u)
    {

    }
}
