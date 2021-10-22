using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]


public class PlayerMovment : MonoBehaviour
{   
    [Tooltip("Velocidad del movimiento del personaje en N/s")]
    [Range(0,1000)]
    public float speed;

    [Tooltip("Velocidad de rotacion del personaje en newton/ segundos")]
    [Range (0,100)]
    public float rotationspeed;

    private Rigidbody rb;
  
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float space = speed * Time.deltaTime;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        // transform.Translate(dir.normalized*space);

        rb.AddRelativeForce(dir.normalized*space);


        float angle = rotationspeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X");
        //transform.Rotate(0, mouseX*angle, 0);

        rb.AddRelativeTorque(0, mouseX * angle, 0);

      
    }

   
}