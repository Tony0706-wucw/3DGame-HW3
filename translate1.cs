using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Starting");
    }

    // Update is called once per frame.
    void Update ()
    {
        transform.position += Vector3.right * Time.deltaTime; //向右移动
        transform.position = new Vector3(transform.position.x, transform.position.x * transform.position.x, 0); //y=x^2
    }
}


