using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float movementSpeed;
    public float deadEnd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movementSpeed) * Time.deltaTime;

        if (transform.position.x < deadEnd)
        {
            Destroy(gameObject);
        }
        
    }
}
