using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float jumpstrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame )
        {
            myRigidBody.linearVelocityY = 1f * jumpstrength;
        }

    }
}
