using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        var rigidBody = GetComponent<Rigidbody2D>();
        // Start coding here
        if (Input.GetKey("right"))
        {
            rigidBody.velocity = new Vector2(5, 0);
        }
        if (Input.GetKey("left"))
        {
            rigidBody.velocity = new Vector2(-5, 0);
        }
        if (Input.GetKey("space"))
        {
            rigidBody.velocity = new Vector2(0, 10);
        }
    }
}
