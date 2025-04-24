using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topBound = 5f;    
    private float lowerBound = -5f; 
    private float leftBound = -5f;  
    private float rightBound = 5f;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check vertical bounds (Y-axis)
        if (transform.position.y > topBound || transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
        // Check horizontal bounds (X-axis)
        if (transform.position.x < leftBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
