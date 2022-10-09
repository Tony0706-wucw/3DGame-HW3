using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting");
    }


    private float t = 1;
    // Update is called once per frame.
    void Update ()
    {
    	t += Time.deltaTime;
        Vector3 next = transform.position + Vector3.right * Time.deltaTime + Vector3.up * t * Time.deltaTime;
        transform.position = Vector3.Slerp(transform.position, next, 1); //平滑运动
}
}
