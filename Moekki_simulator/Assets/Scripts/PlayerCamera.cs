using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    public float turnSpeed = 0.06f;
    public float horizontalInput;
    public float forwardInput;
    public float speed = 16.0f;

    public float sensitivity = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        rotation.x += -Input.GetAxis("Mouse Y");
        rotation.y += Input.GetAxis("Mouse X");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        transform.eulerAngles = (Vector2)rotation * sensitivity;
        //transform.Rotate(Vector3.up*lookAround);
        
        
        
    }
}
