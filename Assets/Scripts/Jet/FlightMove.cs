using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightMove : MonoBehaviour
{
    private float moveX;
    private float moveY;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        if (moveX != 0 && moveY != 0)
        {
            transform.position = transform.position + new Vector3(moveX * Time.deltaTime * speed, moveY * Time.deltaTime * speed, 0) * 0.8f;
        }
        else
        {
            transform.position = transform.position + new Vector3(moveX * Time.deltaTime * speed, moveY * Time.deltaTime * speed, 0);
        }
    }
}
