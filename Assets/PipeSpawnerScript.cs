using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2; // Rate at which pipes are spawned
    private float timer = 0;
    public float hightOffset = 10; // Offset from the spawner's position
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffset; // Calculate the lowest point of the pipe
        float highestPoint = transform.position.y + hightOffset; // Calculate the highest point of the pipe

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); // Create a new pipe at the spawner's position
    }
}
