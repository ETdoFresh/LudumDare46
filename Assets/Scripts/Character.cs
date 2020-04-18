using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float movementForce;
    public new Rigidbody2D rigidbody2D;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        var input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        rigidbody2D.AddForce(input * movementForce);

        var eulerAngles = transform.eulerAngles;
        if (input.x > 0) eulerAngles.z = -90;
        else if (input.x < 0) eulerAngles.z = 90;
        else if (input.y > 0) eulerAngles.z = 0;
        else if (input.y < 0) eulerAngles.z = 180;
        transform.eulerAngles = eulerAngles;
    }
}
