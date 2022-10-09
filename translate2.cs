using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting");
    }
     private float t = 1;
    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime; //根据时间的增加移动
        transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        transform.Translate(Vector3.up * t * Time.deltaTime, Space.World);
    }
}
