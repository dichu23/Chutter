using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [Range(0,100)]
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed*Time.deltaTime);



    }
}
