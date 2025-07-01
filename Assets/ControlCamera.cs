using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public float cameraSpeed = 50;
    public float cameraTime = 100;
    public Vector3 newPos;

    public float rot = 10;
    public Quaternion newRot;
    
    // Start is called before the first frame update
    void Start()
    {
        newPos = transform.position;
        newRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            newPos += (transform.right * cameraSpeed);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            newPos += (transform.right * -cameraSpeed);
        if (Input.GetKeyDown(KeyCode.UpArrow))
            newPos += (transform.forward * cameraSpeed);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            newPos += (transform.forward * -cameraSpeed);
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
            newPos += (transform.up * cameraSpeed);
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
            newPos += (transform.up * -cameraSpeed);

        if (Input.GetKeyDown(KeyCode.R))
            newRot *= Quaternion.Euler(Vector3.up * rot);
        if (Input.GetKeyDown(KeyCode.P))
            newRot *= Quaternion.Euler(Vector3.up * -rot);
        if (Input.GetKeyDown(KeyCode.F))
            newRot *= Quaternion.Euler(Vector3.right * rot);
        if (Input.GetKeyDown(KeyCode.L))
            newRot *= Quaternion.Euler(Vector3.right * -rot);
       
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * cameraTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * cameraTime);

    }
}
