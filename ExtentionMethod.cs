using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class ExtentionMethod
{
    static public eKeyState GetKeyState(this eKey a_eKey)
    {
        return SceneManager.GetKeyState(a_eKey);
    }

    static public bool IsKeyUp(this eKey a_eKey)
    {
        return SceneManager.GetKeyState(a_eKey) == eKeyState.Up;
    }

    static public bool IsKeyDown(this eKey a_eKey)
    {
        return SceneManager.GetKeyState(a_eKey) == eKeyState.Down;
    }
}
