using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyMove : MonoBehaviour
{
    private float downSpeed;
    private float verticalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        downSpeed = 2f;
        verticalSpeed = 2f;
        StartCoroutine("StopDownAfterDelay");
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDirection();
        transform.position += new Vector3(verticalSpeed * Time.deltaTime, -1f * downSpeed * Time.deltaTime);
    }

    IEnumerator StopDownAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        downSpeed = 0;
    }

    private void ChangeDirection()
    {
        if (transform.position.x <= -7f)
        {
            verticalSpeed = 2f;
        }
        else if (transform.position.x >= 7f)
        {
            verticalSpeed = -2f;
        }
    }
}
