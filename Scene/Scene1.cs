using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Scene1 : Scene
{
    public Scene1()
    {
        Console.Clear();
        Init();
    }
    Hero user = new Hero(1, new Vec2(5f,5f), new Vec2(1, 1));
    Skill s = new Fire(eSkillType.Fire, new Vec2(16f,16f),new Vec2(1,1), 'f');
    Unit[] monsters = null;
    Map[] arrObj = null;
    Item[] items = null;
    Monster Boss = new Monster(103, new Vec2(20f, 15f), new Vec2(1, 1));
    private void Init()
    {

        arrObj = new Map[]
        {
            new Wall(eObjectType.Wall, 0, 0, '#'),new Wall(eObjectType.Wall, 1, 0, '#'),new Wall(eObjectType.Wall, 2, 0, '#'),new Wall(eObjectType.Wall, 3, 0, '#'),new Wall(eObjectType.Wall, 4, 0, '#'),new Wall(eObjectType.Wall, 5, 0, '#'),new Wall(eObjectType.Wall, 6, 0, '#'),new Wall(eObjectType.Wall, 7, 0, '#'),new Wall(eObjectType.Wall, 8, 0, '#'),new Wall(eObjectType.Wall, 9, 0, '#'),new Wall(eObjectType.Wall, 10, 0, '#'),new Wall(eObjectType.Wall, 11, 0, '#'),new Wall(eObjectType.Wall, 12, 0, '#'),new Wall(eObjectType.Wall, 13, 0, '#'),new Wall(eObjectType.Wall, 14, 0, '#'),new Wall(eObjectType.Wall, 15, 0, '#'),new Wall(eObjectType.Wall, 16, 0, '#'),new Wall(eObjectType.Wall, 17, 0, '#'),new Wall(eObjectType.Wall, 18, 0, '#'),new Wall(eObjectType.Wall, 19, 0, '#'),new Wall(eObjectType.Wall, 20, 0, '#'),new Wall(eObjectType.Wall, 21, 0, '#'),new Wall(eObjectType.Wall, 22, 0, '#'),new Wall(eObjectType.Wall, 23, 0, '#'),new Wall(eObjectType.Wall, 24, 0, '#'),new Wall(eObjectType.Wall, 25, 0, '#'),new Wall(eObjectType.Wall, 26, 0, '#'),new Wall(eObjectType.Wall, 27, 0, '#'),new Wall(eObjectType.Wall, 28, 0, '#'),new Wall(eObjectType.Wall, 29, 0, '#'),new Wall(eObjectType.Wall, 30, 0, '#'),new Wall(eObjectType.Wall, 31, 0, '#'),new Wall(eObjectType.Wall, 32, 0, '#'),new Wall(eObjectType.Wall, 33, 0, '#'),new Wall(eObjectType.Wall, 34, 0, '#'),new Wall(eObjectType.Wall, 35, 0, '#'),new Wall(eObjectType.Wall, 36, 0, '#'),new Wall(eObjectType.Wall, 37, 0, '#'),new Wall(eObjectType.Wall, 38, 0, '#'),new Wall(eObjectType.Wall, 39, 0, '#'),new Wall(eObjectType.Wall, 40, 0, '#'),new Wall(eObjectType.Wall, 41, 0, '#'),new Wall(eObjectType.Wall, 42, 0, '#'),new Wall(eObjectType.Wall, 43, 0, '#'),new Wall(eObjectType.Wall, 44, 0, '#'),new Wall(eObjectType.Wall, 45, 0, '#'),new Wall(eObjectType.Wall, 46, 0, '#'),new Wall(eObjectType.Wall, 47, 0, '#'),new Wall(eObjectType.Wall, 48, 0, '#'),new Wall(eObjectType.Wall, 49, 0, '#'),new Wall(eObjectType.Wall, 50, 0, '#'),new Wall(eObjectType.Wall, 51, 0, '#'),new Wall(eObjectType.Wall, 52, 0, '#'),new Wall(eObjectType.Wall, 53, 0, '#'),new Wall(eObjectType.Wall, 54, 0, '#'),new Wall(eObjectType.Wall, 55, 0, '#'),new Wall(eObjectType.Wall, 56, 0, '#'),new Wall(eObjectType.Wall, 57, 0, '#'),new Wall(eObjectType.Wall, 58, 0, '#'),new Wall(eObjectType.Wall, 59, 0, '#'),new Wall(eObjectType.Wall, 60, 0, '#'),new Wall(eObjectType.Wall, 61, 0, '#'),new Wall(eObjectType.Wall, 62, 0, '#'),new Wall(eObjectType.Wall, 63, 0, '#'),new Wall(eObjectType.Wall, 64, 0, '#'),new Wall(eObjectType.Wall, 65, 0, '#'),new Wall(eObjectType.Wall, 66, 0, '#'),new Wall(eObjectType.Wall, 67, 0, '#'),new Wall(eObjectType.Wall, 68, 0, '#'),new Wall(eObjectType.Wall, 69, 0, '#'),new Wall(eObjectType.Wall, 70, 0, '#'),new Wall(eObjectType.Wall, 71, 0, '#'),new Wall(eObjectType.Wall, 72, 0, '#'),new Wall(eObjectType.Wall, 73, 0, '#'),new Wall(eObjectType.Wall, 74, 0, '#'),new Wall(eObjectType.Wall, 75, 0, '#'),new Wall(eObjectType.Wall, 76, 0, '#'),new Wall(eObjectType.Wall, 77, 0, '#'),new Wall(eObjectType.Wall, 78, 0, '#'),new Wall(eObjectType.Wall, 79, 0, '#'),new Wall(eObjectType.Wall, 80, 0, '#'),new Wall(eObjectType.Wall, 81, 0, '#'),new Wall(eObjectType.Wall, 82, 0, '#'),new Wall(eObjectType.Wall, 83, 0, '#'),new Wall(eObjectType.Wall, 84, 0, '#'),new Wall(eObjectType.Wall, 85, 0, '#'),new Wall(eObjectType.Wall, 86, 0, '#'),new Wall(eObjectType.Wall, 87, 0, '#'),new Wall(eObjectType.Wall, 88, 0, '#'),new Wall(eObjectType.Wall, 89, 0, '#'),new Wall(eObjectType.Wall, 90, 0, '#'),
            new Wall(eObjectType.Wall, 0, 1, '#'),new WaterWall(eObjectType.WaterWall,3,3, ' '),new Wall(eObjectType.Wall, 90, 1, '#'),
            new Wall(eObjectType.Wall, 0, 2, '#'),new WaterWall(eObjectType.WaterWall,3,4, ' '),new Wall(eObjectType.Wall, 90, 2, '#'),
            new Wall(eObjectType.Wall, 0, 3, '#'),new WaterWall(eObjectType.WaterWall,3,5, ' '),new Wall(eObjectType.Wall, 90, 3, '#'),
            new Wall(eObjectType.Wall, 0, 4, '#'),new FireWall(eObjectType.FireWall,11,12,'F'), new Wall(eObjectType.Wall, 90, 4, '#'),
            new Wall(eObjectType.Wall, 0, 5, '#'),new FireWall(eObjectType.FireWall,11,13,'F'), new Wall(eObjectType.Wall, 90, 5, '#'),
            new Wall(eObjectType.Wall, 0, 6, '#'),new FireWall(eObjectType.FireWall,11,14,'F'), new Wall(eObjectType.Wall, 90, 6, '#'),
            new Wall(eObjectType.Wall, 0, 7, '#'),                                              new Wall(eObjectType.Wall, 90, 7, '#'),
            new Wall(eObjectType.Wall, 0, 8, '#'),                                              new Wall(eObjectType.Wall, 90, 8, '#'),
            new Wall(eObjectType.Wall, 0, 9, '#'),                                              new Wall(eObjectType.Wall, 90, 9, '#'),
            new Wall(eObjectType.Wall, 0, 10, '#'),                                             new Wall(eObjectType.Wall, 90, 10, '#'),
            new Wall(eObjectType.Wall, 0, 11, '#'),                                             new Wall(eObjectType.Wall, 90, 11, '#'),
            new Wall(eObjectType.Wall, 0, 12, '#'),                                             new Wall(eObjectType.Wall, 90, 12, '#'),
            new Wall(eObjectType.Wall, 0, 13, '#'),                                             new Wall(eObjectType.Wall, 90, 13, '#'),
            new Wall(eObjectType.Wall, 0, 14, '#'),                                             new Wall(eObjectType.Wall, 90, 14, '#'),
            new Wall(eObjectType.Wall, 0, 15, '#'),                                             new Wall(eObjectType.Wall, 90, 15, '#'),
            new Wall(eObjectType.Wall, 0, 16, '#'),                                             new Wall(eObjectType.Wall, 90, 16, '#'),
            new Wall(eObjectType.Wall, 0, 17, '#'),                                             new Wall(eObjectType.Wall, 90, 17, '#'),
            new Wall(eObjectType.Wall, 0, 18, '#'),                                             new Wall(eObjectType.Wall, 90, 18, '#'),
            new Wall(eObjectType.Wall, 0, 19, '#'),                                             new Wall(eObjectType.Wall, 90, 19, '#'),
            new Wall(eObjectType.Wall, 0, 20, '#'),                                             new Wall(eObjectType.Wall, 90, 20, '#'),
            new Wall(eObjectType.Wall, 0, 21, '#'),                                             new Wall(eObjectType.Wall, 90, 21, '#'),
            new Wall(eObjectType.Wall, 0, 22, '#'),                                             new Wall(eObjectType.Wall, 90, 22, '#'),
            new Wall(eObjectType.Wall, 0, 23, '#'),                                             new Wall(eObjectType.Wall, 90, 23, '#'),
            new Wall(eObjectType.Wall, 0, 24, '#'),                                             new Wall(eObjectType.Wall, 90, 24, '#'),
            new Wall(eObjectType.Wall, 0, 25, '#'),                                             new Wall(eObjectType.Wall, 90, 25, '#'),
            new Wall(eObjectType.Wall, 0, 26, '#'),                                             new Wall(eObjectType.Wall, 90, 26, '#'),
            new Wall(eObjectType.Wall, 0, 27, '#'),                                             new Wall(eObjectType.Wall, 90, 27, '#'),
            new Wall(eObjectType.Wall, 0, 28, '#'),                                             new Wall(eObjectType.Wall, 90, 28, '#'),
            new Wall(eObjectType.Wall, 0, 29, '#'),                                             new Wall(eObjectType.Wall, 90, 29, '#'),
            new Wall(eObjectType.Wall, 0, 30, '#'),                                             new Wall(eObjectType.Wall, 90, 30, '#'),
            new Wall(eObjectType.Wall, 0, 31, '#'),                                             new Wall(eObjectType.Wall, 90, 31, '#'),
            new Wall(eObjectType.Wall, 0, 32, '#'),                                             new Wall(eObjectType.Wall, 90, 32, '#'),
            new Wall(eObjectType.Wall, 0, 33, '#'),                                             new Wall(eObjectType.Wall, 90, 33, '#'),
            new Wall(eObjectType.Wall, 0, 34, '#'),                                             new Wall(eObjectType.Wall, 90, 34, '#'),
            new Wall(eObjectType.Wall, 0, 35, '#'),                                             new Wall(eObjectType.Wall, 90, 35, '#'),
            new Wall(eObjectType.Wall, 0, 36, '#'),                                             new Wall(eObjectType.Wall, 90, 36, '#'),
            new Wall(eObjectType.Wall, 0, 37, '#'),                                             new Wall(eObjectType.Wall, 90, 37, '#'),
            new Wall(eObjectType.Wall, 0, 38, '#'),                                             new Wall(eObjectType.Wall, 90, 38, '#'),
            new Wall(eObjectType.Wall, 0, 39, '#'),new Wall(eObjectType.Wall, 1, 39, '#'),new Wall(eObjectType.Wall, 2, 39, '#'),new Wall(eObjectType.Wall, 3, 39, '#'),new Wall(eObjectType.Wall, 4, 39, '#'),new Wall(eObjectType.Wall, 5, 39, '#'),new Wall(eObjectType.Wall, 6, 39, '#'),new Wall(eObjectType.Wall, 7, 39, '#'),new Wall(eObjectType.Wall, 8, 39, '#'),new Wall(eObjectType.Wall, 9, 39, '#'),new Wall(eObjectType.Wall, 10, 39, '#'),new Wall(eObjectType.Wall, 11, 39, '#'),new Wall(eObjectType.Wall, 12, 39, '#'),new Wall(eObjectType.Wall, 13, 39, '#'),new Wall(eObjectType.Wall, 14, 39, '#'),new Wall(eObjectType.Wall, 15, 39, '#'),new Wall(eObjectType.Wall, 16, 39, '#'),new Wall(eObjectType.Wall, 17, 39, '#'),new Wall(eObjectType.Wall, 18, 39, '#'),new Wall(eObjectType.Wall, 19, 39, '#'),new Wall(eObjectType.Wall, 20, 39, '#'),new Wall(eObjectType.Wall, 21, 39, '#'),new Wall(eObjectType.Wall, 22, 39, '#'),new Wall(eObjectType.Wall, 23, 39, '#'),new Wall(eObjectType.Wall, 24, 39, '#'),new Wall(eObjectType.Wall, 25, 39, '#'),new Wall(eObjectType.Wall, 26, 39, '#'),new Wall(eObjectType.Wall, 27, 39, '#'),new Wall(eObjectType.Wall, 28, 39, '#'),new Wall(eObjectType.Wall, 29, 39, '#'),new Wall(eObjectType.Wall, 30, 39, '#'),new Wall(eObjectType.Wall, 31, 39, '#'),new Wall(eObjectType.Wall, 32, 39, '#'),new Wall(eObjectType.Wall, 33, 39, '#'),new Wall(eObjectType.Wall, 34, 39, '#'),new Wall(eObjectType.Wall, 35, 39, '#'),new Wall(eObjectType.Wall, 36, 39, '#'),new Wall(eObjectType.Wall, 37, 39, '#'),new Wall(eObjectType.Wall, 38, 39, '#'),new Wall(eObjectType.Wall, 39, 39, '#'),new Wall(eObjectType.Wall, 40, 39, '#'),new Wall(eObjectType.Wall, 41, 39, '#'),new Wall(eObjectType.Wall, 42, 39, '#'),new Wall(eObjectType.Wall, 43, 39, '#'),new Wall(eObjectType.Wall, 44, 39, '#'),new Wall(eObjectType.Wall, 45, 39, '#'),new Wall(eObjectType.Wall, 46, 39, '#'),new Wall(eObjectType.Wall, 47, 39, '#'),new Wall(eObjectType.Wall, 48, 39, '#'),new Wall(eObjectType.Wall, 49, 39, '#'),new Wall(eObjectType.Wall, 50, 39, '#'),new Wall(eObjectType.Wall, 51, 39, '#'),new Wall(eObjectType.Wall, 52, 39, '#'),new Wall(eObjectType.Wall, 53, 39, '#'),new Wall(eObjectType.Wall, 54, 39, '#'),new Wall(eObjectType.Wall, 55, 39, '#'),new Wall(eObjectType.Wall, 56, 39, '#'),new Wall(eObjectType.Wall, 57, 39, '#'),new Wall(eObjectType.Wall, 58, 39, '#'),new Wall(eObjectType.Wall, 59, 39, '#'),new Wall(eObjectType.Wall, 60, 39, '#'),new Wall(eObjectType.Wall, 61, 39, '#'),new Wall(eObjectType.Wall, 62, 39, '#'),new Wall(eObjectType.Wall, 63, 39, '#'),new Wall(eObjectType.Wall, 64, 39, '#'),new Wall(eObjectType.Wall, 65, 39, '#'),new Wall(eObjectType.Wall, 66, 39, '#'),new Wall(eObjectType.Wall, 67, 39, '#'),new Wall(eObjectType.Wall, 68, 39, '#'),new Wall(eObjectType.Wall, 69, 39, '#'),new Wall(eObjectType.Wall, 70, 39, '#'),new Wall(eObjectType.Wall, 71, 39, '#'),new Wall(eObjectType.Wall, 72, 39, '#'),new Wall(eObjectType.Wall, 73, 39, '#'),new Wall(eObjectType.Wall, 74, 39, '#'),new Wall(eObjectType.Wall, 75, 39, '#'),new Wall(eObjectType.Wall, 76, 39, '#'),new Wall(eObjectType.Wall, 77, 39, '#'),new Wall(eObjectType.Wall, 78, 39, '#'),new Wall(eObjectType.Wall, 79, 39, '#'),new Wall(eObjectType.Wall, 80, 39, '#'),new Wall(eObjectType.Wall, 81, 39, '#'),new Wall(eObjectType.Wall, 82, 39, '#'),new Wall(eObjectType.Wall, 83, 39, '#'),new Wall(eObjectType.Wall, 84, 39, '#'),new Wall(eObjectType.Wall, 85, 39, '#'),new Wall(eObjectType.Wall, 86, 39, '#'),new Wall(eObjectType.Wall, 87, 39, '#'),new Wall(eObjectType.Wall, 88, 39, '#'),new Wall(eObjectType.Wall, 89, 39, '#'),new Wall(eObjectType.Wall, 90, 39, '#'),
            new Wall(eObjectType.Wall, 0, 1, '#'),
        };
        items = new Item[]
        {
            new Item(eItemType.HPUp, 10, 10,'H'),
            new Item(eItemType.PowUp, 11, 11, 'P'),
            new Item(eItemType.DefUp, 12, 12, 'D'),
        };
        monsters = new Monster[]
        {
            new Monster(101, new Vec2(15f,15f), new Vec2(1, 1)),
            new Monster(102, new Vec2(1f,12f), new Vec2(1, 1)),
        };
    }

    public static void PrintStatus(Hero h)
    {
        Console.SetCursorPosition(0, 40);
        h.Info();
    }

    public override int Update(float a_fDelta)
    {
        eDir eDir = eDir.None;

        if (eKey.Left.IsKeyDown() == true)
        {
            eDir = eDir.Left;
        }
        else if (eKey.Right.IsKeyDown() == true)
        {
            eDir = eDir.Right;
        }

        if (eKey.Down.IsKeyDown() == true)
        {
            eDir = eDir.Bottom;
        }
        else if (eKey.Up.IsKeyDown() == true)
        {
            eDir = eDir.Top;
        }

        if (eKey.Z.IsKeyDown() == true)
        {
            if (user.activeZ == false) { return 0; }
            foreach (var temp in monsters)
                user.ActiveSkill(eSkillType.Fire, temp);
            s.Update(user, a_fDelta);
        }

        if (eDir != eDir.None)
        {
            user.Update(eDir);
        }

        return 0;
    }
    public void UIRender()
    {
        PrintStatus(user);
    }

    public override void Render()
    {
        UIRender();
        foreach (var temp in arrObj)
            temp.Render();
        foreach (var temp in items)
            temp.Render();
        foreach (var temp in monsters)
            temp.Render();
        s.Render();
        Boss.Render();
        user.Render();
    }

    public override void Interaction()
    {
        foreach (var temp in arrObj)
            temp.Interaction(user);
        foreach (var temp in items)
            temp.Interaction(user);
        foreach (var temp in monsters)
            temp.Interaction(user);
        Boss.Interaction(user);
        s.Interaction(user);
    }
}
