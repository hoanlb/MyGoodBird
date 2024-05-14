using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime;
    float timer;
    public float height;

    private void Start()
    {
        timer = maxTime;
    }

    private void Update()
    {
        int min = -3;
        int max = -6;
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(pipe, new Vector3(transform.position.x, Random.Range(min, max), 0), Quaternion.identity);

            Destroy(tmp, 10f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
