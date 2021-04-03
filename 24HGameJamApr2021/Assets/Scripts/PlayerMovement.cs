using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Camera;
    public float fbMovementSpeed;
    public float sidewaysMovementSpeed;
    private float mouseSensitivity = 2f;
    private Vector3 fbForceVector;
    private Vector3 sidewaysForceVector;
    private Vector3 walkingForceVector;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Camera = GameObject.Find("Main Camera");
    }

    void OnEnable()
    {
        Cursor.visible = false;
    }

    void OnDisable()
    {
        Cursor.visible = true;
    }

    void Update()
    {   
        float yRotation = Input.GetAxis("Mouse X");
        float xRotation = Input.GetAxis("Mouse Y");

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        Camera.transform.Rotate(xRotation * mouseSensitivity * Vector3.left);
        gameObject.transform.Rotate(yRotation * mouseSensitivity * Vector3.up);


        float fbMovement = Input.GetAxis("Vertical");
        float sidewaysMovement = Input.GetAxis("Horizontal");

        double radians =  Math.PI * gameObject.transform.eulerAngles.y / 180.0;

        float Sinus = Convert.ToSingle(Math.Sin(radians));
        float Cosinus = Convert.ToSingle(Math.Cos(radians));

        

        fbForceVector = new Vector3(Sinus * fbMovement * fbMovementSpeed * Time.deltaTime, 0, Cosinus * fbMovement *fbMovementSpeed * Time.deltaTime);
        sidewaysForceVector = new Vector3(Cosinus * sidewaysMovement * sidewaysMovementSpeed * Time.deltaTime, 0, -Sinus * sidewaysMovement * sidewaysMovementSpeed * Time.deltaTime);
        
        walkingForceVector = fbForceVector + sidewaysForceVector; 
        rb.AddForce(walkingForceVector);
    }
}
