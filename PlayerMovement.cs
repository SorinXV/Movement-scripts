using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I obviously still have to work on this one
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get input from WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

        // Normalize the movement direction
        movementDirection = movementDirection.normalized;

        // Set movement speed
        float movementSpeed = 5.0f;
        movementDirection *= movementSpeed;

        // Apply movement to the player's position
        transform.position += movementDirection * Time.deltaTime;

        // Rotate the player model to face the movement direction
        transform.LookAt(transform.position + movementDirection);
    }
}
    }
}
