using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   // public or privte reference
    // data type (int, float, bool {true/false}, string)
    // every variable has a name
    // oprional value is assigned
    private float _speed = 3.5f;

    //public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        // take the current position and assign the start position = new position (0, 0, 0);
        transform.position = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
             //new Vector3(-5, 0, 0) *5 * real time
        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

       
    }
}
