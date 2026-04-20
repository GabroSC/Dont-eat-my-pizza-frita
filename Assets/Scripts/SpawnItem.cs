using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject prefab;
    
    public float width = 5f;
    public float height = 3f;

    public void SpawnI()
    {
        float randomX = Random.Range(-width / 2, width / 2);
        float randomY = Random.Range(-height / 2, height / 2);


        Vector3 spawnPos = new Vector3(randomX, randomY, 0) + transform.position;

        Instantiate(prefab, spawnPos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0.1f));
    }
    
}
