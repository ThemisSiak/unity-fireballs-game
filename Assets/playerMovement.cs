using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        //x axis
        if (Input.GetKey(KeyCode.A) && transform.position.x > -320)
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && transform.position.x < 320)
            transform.Translate(Vector3.left*(-speed)*Time.deltaTime);
        //z axis
        if (Input.GetKey(KeyCode.S) && transform.position.z < 320)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.X) && transform.position.z > -320)
            transform.Translate(Vector3.forward * (-speed) * Time.deltaTime);
        //y axis
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up*speed*Time.deltaTime);
        if (Input.GetKey(KeyCode.E) && transform.position.y > 220)
            transform.Translate(Vector3.up*(-speed)*Time.deltaTime);
    }
}
