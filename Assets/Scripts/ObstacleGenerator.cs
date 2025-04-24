using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{

    public GameObject circlePrefab; 
    public int numberOfCirclesPerLine = 4; 
    public float spacing = 2f; 
    public float offsetFromCenter = 2f; 
    public int numberOfDirections = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float angleStep = 360f / numberOfDirections;
        for (int d = 0; d < numberOfDirections; d++)
        {
            float angle = d * angleStep * Mathf.Deg2Rad; 
            Vector3 direction = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);

            for (int i = 0; i < numberOfCirclesPerLine; i++)
            {
                Vector3 position = direction * (offsetFromCenter + i * spacing);
                GameObject circle = Instantiate(circlePrefab, position, Quaternion.identity);
                circle.transform.SetParent(transform); 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
