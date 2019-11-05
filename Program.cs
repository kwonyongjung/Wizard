using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static float GetTargetFPSTicks()
    {
        const float nTarget = 60; // 1초당 60번
        return 10000 * 1000 / nTarget;
    }
    [STAThread]
    static void Main()
    {
        Console.CursorVisible = false;
        Console.Title = "게임";
        Console.SetWindowSize(150, 45);
        TableManager.CreateInstance();
        SceneManager.CraeteInstance();

        DateTime Old = DateTime.Now;
        long Ticks = 0;
        long TargetTicks = (long)GetTargetFPSTicks();

        SceneManager sceneMng = SceneManager.Get();

        while (true)
        {
            long Temp = (DateTime.Now - Old).Ticks;
            Old = DateTime.Now;

            Ticks += Temp;

            if (Ticks > TargetTicks)
            {
                if (sceneMng.Update(Ticks / (float)(10000 * 1000)) == 1)
                    sceneMng.ChangeScene(eScene.Stage1);
                if (sceneMng.Update(Ticks / (float)(10000 * 1000)) == 2)
                    sceneMng.ChangeScene(eScene.Stage2);
                if (sceneMng.Update(Ticks / (float)(10000 * 1000)) == -1)
                    return;
                sceneMng.Render();
                sceneMng.Interaction();

                Ticks -= TargetTicks;
            }
        }
    }
}