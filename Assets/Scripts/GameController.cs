using UnityEngine;

public static class GameController
{

    public static bool gameOver
    {
        get { return Cronometro.time <= 0 || PlayerHealth.health == 0; }
    }
    
    public static void Init()
    {
        Cronometro.Init();
        PlayerHealth.Init();
        Score.Init();
    }

    public static void Collect()
    {
        Cronometro.time += 2;
    }
    

}
