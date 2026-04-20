using System;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int health;
    private Rigidbody2D rb;
    private float timeCollision;

    public static void Init()
    {
        health = 3;
    }

    private void Update()
    {
        timeCollision += Time.deltaTime;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            if (timeCollision > 1 || health == 3)
            {
                Enemy.PlaySound();
                timeCollision = 0;
                health -= 1;
            }
        }
    }
}
