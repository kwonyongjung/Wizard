using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
enum eDir
{
    None,
    Left,
    Top,
    Right,
    Bottom,
}

enum eScene
{
    Start,
    Stage1,
    Stage2,
}

enum eKey
{
    Up      = Key.Up,
    Down    = Key.Down,
    Left    = Key.Left,
    Right   = Key.Right,
    Space   = Key.Space,
    A       = Key.A,
    S       = Key.S,
    D       = Key.D,
    Z       = Key.Z,
    X       = Key.X,
    C       = Key.C,
    Q       = Key.Q,
    Enter   = Key.Enter,
    Max = 13,
}

[Flags]
enum eKeyState
{
    Unpress = 0b00,
    Down    = 0b11,
    Press   = 0b01,
    Up      = 0b10,
}

enum eObjectType
{
    Wall,
    FireWall,
    WaterWall,
    Rock,
}

enum eItemType
{
    HPUp,
    PowUp,
    DefUp,
}

enum eSkillType
{
    None,
    Fire,
    Ice,
    Water,
    Wind,
    Earth,
}

struct Vec2
{
    public float x;
    public float y;

    public Vec2(float _x, float _y)
    {
        x = _x; y = _y;
    }

    public static Vec2 operator +(Vec2 a, Vec2 b)
    {
        return new Vec2(a.x, a.y);
    }

    public static Vec2 operator *(Vec2 a, float b)
    {
        return new Vec2(a.x + b, a.y + b);
    }
}

static class Define
{
    static Hero Save = null;
    public static void SaveStatus(Hero h)
    {
        Hero Save = h;
    }
    public static Hero GetStatus()
    {
        return Save;
    }
    public static void Render(int x, int y, char c)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
    }
    static public bool ConsoleBoundaryCheck(Vec2 v)
    {
        return !(
            (v.x < 0 || v.x > Console.WindowWidth) ||
            (v.y < 0 || v.y > Console.WindowHeight));
    }
}
