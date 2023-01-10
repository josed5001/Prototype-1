using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 25f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float fowardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player Inputs vv
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");
        // We Move the veichle foward


        // Veichle Goes Foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        // Veichle Goes Sideways
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
