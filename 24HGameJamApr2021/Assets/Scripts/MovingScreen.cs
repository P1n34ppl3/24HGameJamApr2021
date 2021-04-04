using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScreen : MonoBehaviour
{
    public float rotationInMenuSpeed;

    void Update()
    {
        gameObject.transform.Rotate(0f,rotationInMenuSpeed * Time.deltaTime,0f);
    }
}

