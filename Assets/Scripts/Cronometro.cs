using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public static float time;
    public static float timeTotal;
    [SerializeField] TextMeshProUGUI timerTxt;
    public static bool gameOver = false;
    
    public static void Init()
    {
        gameOver = false;
        time = 10;
        timeTotal = 0;
    }
    
    void Update()
    {
        if (gameOver == false)
        {
            time -= Time.deltaTime;
            timeTotal += Time.deltaTime;
            timerTxt.text = time.ToString("F2");
        }

    }
    
    

}
