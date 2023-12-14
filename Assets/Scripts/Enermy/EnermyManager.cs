using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyManager : MonoBehaviour
{
    public List<GameObject> enermyList;
    private float timer;
    private float spawnTimer;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        spawnTimer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTimer)
        {
            Instantiate(enermyList[0], new Vector3(Random.Range(-7f, 7f), 7f, 0), Quaternion.identity);
            timer = 0;
        }
    }
}
