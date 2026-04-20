using TMPro;
using UnityEngine;

public class TextHealth : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textHealth;
    void Update()
    {
        if (PlayerHealth.health >= 0)
        {
            textHealth.text = PlayerHealth.health.ToString();
        }
    }
}
