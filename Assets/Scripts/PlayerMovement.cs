using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 oldVelocity = rb2D.velocity;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            oldVelocity.y = 6;
        }
        oldVelocity.x = 4;
        rb2D.velocity = oldVelocity;
    }
}
