using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

class SceneManager
{
    #region SINGLETON

    static SceneManager instance = null;

    static public void CraeteInstance()
    {
        if (instance == null)
        {
            instance = new SceneManager();
            instance.Init();
        }
    }
    static public SceneManager Get() { return instance; }

    SceneManager() { }

    #endregion SINGLETON


    Scene m_pNowScene = null;


    void Init()
    {
        ChangeScene(eScene.Start);

        arValue[0] = eKey.Up;
        arValue[1] = eKey.Down;
        arValue[2] = eKey.Left;
        arValue[3] = eKey.Right;
        arValue[4] = eKey.Space;
        arValue[5] = eKey.A;
        arValue[6] = eKey.S;
        arValue[7] = eKey.D;
        arValue[8] = eKey.Z;
        arValue[9] = eKey.X;
        arValue[10] = eKey.C;
        arValue[11] = eKey.Q;
        arValue[12] = eKey.Enter;

        for (int i = 0; i < m_arStates.Length; ++i)
        {
            m_arOldStates[i] = m_arStates[i] = eKeyState.Unpress;
        }
    }

    public void ChangeScene(eScene a_eScene)
    {
        m_pNowScene = null;

        switch (a_eScene)
        {
            case eScene.Start:
                { m_pNowScene = new Start(); }
                break;
            case eScene.Stage1:
                { m_pNowScene = new Scene1(); }
                break;
            case eScene.Stage2:
                { m_pNowScene = new Scene2(); }
                break;
        }
    }

    public int Update(float a_fDelta)
    {
        int nReturn;
        nReturn = m_pNowScene.Update(a_fDelta);
        InputCheck();
        return nReturn;
    }

    public void Render()
    {
        m_pNowScene.Render();
    }

    public void Interaction()
    {
        m_pNowScene.Interaction();
    }

    void InputCheck()
    {
        for (int i = 0; i < (int)eKey.Max; ++i)
        {
            int nNowPress = (Keyboard.IsKeyDown((Key)arValue[i]) == true) ? 1 : 0;
            m_arStates[i] = (eKeyState)(nNowPress | (int)m_arOldStates[i]);
            m_arOldStates[i] = (eKeyState)(nNowPress << 1);
        }
    }

    static eKeyState[] m_arStates = new eKeyState[(int)eKey.Max];
    static eKeyState[] m_arOldStates = new eKeyState[(int)eKey.Max];

    static eKey[] arValue = new eKey[(int)eKey.Max];

    static int GetIndex(eKey a_eKey)
    {
        int nReturn = -1;
        for (int i = 0; i < arValue.Length; ++i)
        {
            if (arValue[i] == a_eKey)
            {
                nReturn = i;
                break;
            }
        }

        return nReturn;
    }

    public static eKeyState GetKeyState(eKey a_eKey)
    {
        return m_arStates[GetIndex(a_eKey)];
    }
}
