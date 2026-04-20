using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject timer;
    public GameObject health;
    public GameObject scoreTxt;
    

    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            Cronometro.gameOver = true;
            endPanel.SetActive(true);
            timer.SetActive(false);
            health.SetActive(false);
            scoreTxt.SetActive(false);
            
        }
        
    }
}
