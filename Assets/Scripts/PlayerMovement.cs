using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed , turn_speed;
    public Rigidbody rb;
    float x;
    Vector3 movement,forward,hor;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        forward = transform.forward * speed * Time.fixedDeltaTime;
        hor = transform.right * x * speed * turn_speed* Time.fixedDeltaTime;

        rb.MovePosition(rb.position + forward+hor);
        /*
        forward = Vector3.forward;

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        transform.Translate(forward * speed * Time.deltaTime, Space.World);
        */

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");

        //x = Input.GetAxis("Horizontal") * 10f * Time.deltaTime;
        //y = Input.GetAxis("Vertical") * 10f * Time.deltaTime;

        //movement = new Vector3(x, 0.0f, y);
       // movement = new Vector3(x, 0, 0);
       // movement.Normalize();
    }
}
