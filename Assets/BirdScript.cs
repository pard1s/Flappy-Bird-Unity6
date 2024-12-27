using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // this is a reference to the Rigid body component of the object. this will actually create a field in the element inspector under the script component. then we will be abele to drag and drop the rigid body component to MyRigidbodyy field
    public float flapStrength =15; // this is the strength of the flap. this will be set in the element inspector
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // Find the LogicScript component in the scene
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive) // this will check if the space key is pressed
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength; // this will move the bird up by 2 units per second
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
