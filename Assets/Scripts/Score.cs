using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreTxt;
    public static int scoreNum = 0;

    public static void Init()
    {
        scoreNum = 0;
    }
    
    static public void score()
    {
       scoreNum += 50; 
    }

    private void Update()
    {
        scoreTxt.text = scoreNum.ToString();
    }
}
