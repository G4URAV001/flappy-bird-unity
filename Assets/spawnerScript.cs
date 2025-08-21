using System.Threading;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime;
    private float timer;
    public float spawnerOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <spawnTime)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Spawner();
            timer = 0;
        }
    }

    void Spawner()
    {
        float maxheight = transform.position.y - spawnerOffset;
        float minheight = transform.position.y + spawnerOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(maxheight, minheight), 0), transform.rotation);
    }
}
