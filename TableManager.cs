using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TableManager
{
    #region SINGLETON
    private static TableManager m_Intance = null;

    public static void CreateInstance()
    {
        if (m_Intance == null)
            m_Intance = new TableManager();
    }

    public static TableManager Ins()
    {
        return m_Intance;
    }
    #endregion SINGLETON
    public Dictionary<int, UnitTable> m_mapUnitTb = new Dictionary<int, UnitTable>();
    public Dictionary<eObjectType, ObjectTable> m_mapObjTb = new Dictionary<eObjectType, ObjectTable>();
    public Dictionary<eItemType, ItemTable> m_mapItemTb = new Dictionary<eItemType, ItemTable>();
    public Dictionary<eSkillType, SkillTable> m_mapSkillTb = new Dictionary<eSkillType, SkillTable>();
    private TableManager()
    {
        m_mapUnitTb.Add(1, new UnitTable(1, "법사", 10, 5, 100, 0.25f, 'M'));
        m_mapUnitTb.Add(2, new UnitTable(2, "전사", 8, 8, 150, 0.25f, 'W'));
        m_mapUnitTb.Add(101, new UnitTable(101, "오크", 10, 3, 50, 0.25f, 'o'));
        m_mapUnitTb.Add(102, new UnitTable(102, "오거", 15, 5, 100, 0.25f, 'O'));
        m_mapUnitTb.Add(103, new UnitTable(103, "보스", 15, 5, 100, 0.25f, 'B'));

        m_mapObjTb.Add(eObjectType.Wall, new ObjectTable(eObjectType.Wall, 0, 1000, 600));
        m_mapObjTb.Add(eObjectType.WaterWall, new ObjectTable(eObjectType.WaterWall, 0, 0, 0));
        m_mapObjTb.Add(eObjectType.FireWall, new ObjectTable(eObjectType.FireWall, 0, 0, 10));

        m_mapItemTb.Add(eItemType.HPUp, new ItemTable(eItemType.HPUp,0,0,100));
        m_mapItemTb.Add(eItemType.PowUp, new ItemTable(eItemType.PowUp, 20, 0, 0));
        m_mapItemTb.Add(eItemType.DefUp, new ItemTable(eItemType.DefUp, 0, 10, 0));

        m_mapSkillTb.Add(eSkillType.Fire, new SkillTable(eSkillType.Fire, 0, 0, 10, 3));
        m_mapSkillTb.Add(eSkillType.Ice, new SkillTable(eSkillType.Ice, 0, 0, 10, 10));
    }

    public bool GetUnitTable(int a_nID, out UnitTable a_refTb)
    {
        return m_mapUnitTb.TryGetValue(a_nID, out a_refTb);
    }

    public bool GetObjTable(eObjectType a_eType, out ObjectTable a_refTb)
    {
        return m_mapObjTb.TryGetValue(a_eType, out a_refTb);
    }

    public bool GetItemTable(eItemType a_eType, out ItemTable a_refTb)
    {
        return m_mapItemTb.TryGetValue(a_eType, out a_refTb);
    }

    public bool GetSkillTable(eSkillType a_eType, out SkillTable a_refTb)
    {
        return m_mapSkillTb.TryGetValue(a_eType, out a_refTb);
    }
}