using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Map
{
    public int m_nX;
    public int m_nY;
    public char m_cRender;
    public eObjectType m_eType;
    public bool bExist = true;
    public Map(eObjectType a_eType, int a_nX, int a_nY, char a_cRender)
    {
        m_eType = a_eType;
        m_nX = a_nX;
        m_nY = a_nY;
        m_cRender = a_cRender;
    }
    virtual public void Update()
    {

    }

    virtual public void Render()
    {
        if (bExist == false) { return; }
        Define.Render(m_nX, m_nY, m_cRender);
    }

    public virtual void Interaction(Unit u)
    {
        if (m_nX != (int)u.m_vcPos.x || m_nY != (int)u.m_vcPos.y) { return; }
        if (u.LastMove == eDir.None) { return; }

        eDir rollBack = eDir.None;

        switch (u.LastMove)
        {
            case eDir.Left: rollBack = eDir.Right; break;
            case eDir.Top: rollBack = eDir.Bottom; break;
            case eDir.Right: rollBack = eDir.Left; break;
            case eDir.Bottom: rollBack = eDir.Top; break;
        }

        u.Move(rollBack);
        u.Render();

        Render();
    }
}
