using TMPro;
using UnityEngine;

public class TempoJogo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerTxt;
    
    // Update is called once per frame
    void Update()
    {
        timerTxt.text = Cronometro.timeTotal.ToString("F2");
    }
}
