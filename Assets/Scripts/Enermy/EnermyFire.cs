using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyFire : MonoBehaviour
{
    private float fireCoolDown;
    private float timer;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        fireCoolDown = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireCoolDown)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
