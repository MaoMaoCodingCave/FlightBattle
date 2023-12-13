using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    private bool canFire;
    // 设定的发射冷却，可通过吃道具变快，也会有debuff变慢。
    private float fireCoolDown = 1f;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        canFire = true;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            canFire = false;
            StartCoroutine("FireCoolDown");
        }
    }

    IEnumerator FireCoolDown()
    {
        yield return new WaitForSeconds(fireCoolDown);
        canFire = true;
        yield return null;
    }
}
