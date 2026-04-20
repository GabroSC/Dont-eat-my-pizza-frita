using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    private static AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        float angle = Mathf.Atan2(direction.x, -direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    
    public static void PlaySound()
    {
        audioSource.Play();
    }
}