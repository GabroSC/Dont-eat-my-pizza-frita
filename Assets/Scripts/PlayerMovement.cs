using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private AudioSource audio;
    public SpawnItem spawnItem;
    private PlayerAnimController playerAnim;
    private bool isWalkingState = false;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        playerAnim = GetComponent<PlayerAnimController>();
    }


    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector2 movementNormalized = movement.normalized;

        if (movementNormalized != Vector2.zero)
        {
            float angle = Mathf.Atan2(movementNormalized.x, -movementNormalized.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        rb.MovePosition(rb.position + movementNormalized * speed * Time.fixedDeltaTime);

        bool isMoving = (movementNormalized.magnitude > 0);

        if (isMoving != isWalkingState)
        {
            isWalkingState = isMoving;
            if (playerAnim != null)
            {
                playerAnim.Anima(isWalkingState ? "PlayerRunYAnim" : "PlayerIdleAnim");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coleta")
        {
            audio.Play();
            GameController.Collect();
            Destroy(other.gameObject);
            spawnItem.SpawnI();
            Score.score();
        }
    }
}