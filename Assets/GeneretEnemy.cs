using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneretEnemy : MonoBehaviour
{
    public GameObject[] inimigo;
    private float timer = 0;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f)
        {

            timer = 0;
            Instantiate(inimigo[Random.Range(0, 7)], new Vector3(Random.Range(5.61f, -5.61f), transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -180f));


        }

    }
}
