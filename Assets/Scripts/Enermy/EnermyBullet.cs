using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyBullet : MonoBehaviour
{
    private float speed;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y <= -6f)
        {
            Destroy(this.gameObject);
        }
    }
}
