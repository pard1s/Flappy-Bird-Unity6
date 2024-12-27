using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public float moveSpeed = 5; // Speed of the box
    public float deadZone = -45; // The x position where the pipe is destroyed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime); // Move the box to the left, deltaTime is used to make the movement frame rate independent

        if (transform.position.x < deadZone) // Check if the box is out of the screen
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); // Destroy the box
        }
    }
}
