using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab; 
    [SerializeField] private float spawnInterval = 2f; 
    [SerializeField] private float spawnYPosition = 5f;
    [SerializeField] private float minX = -5f;
    [SerializeField] private float maxX = 5f;

    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnProjectiles();
            timer = 0f;
        }
    }

    void SpawnProjectiles()
    {
        int projectileCount = Random.Range(3, 6); 
        for (int i = 0; i < projectileCount; i++)
        {
            float randomX = Random.Range(minX, maxX); 
            Vector2 spawnPosition = new Vector2(randomX, spawnYPosition);
            GameObject projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
