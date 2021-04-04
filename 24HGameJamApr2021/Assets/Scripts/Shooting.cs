using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Transform Player;
    public GameObject BulletPrefab;
    public float ReloadTime = 1f;

    void Update()
    {
        Trigger();
    }
    void Trigger()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("Shoot", ReloadTime);
        }
    }
    void Shoot()
    {
        Debug.Log("shoot");
            Instantiate(BulletPrefab, Player.position, Player.rotation);
        
           
    }
}
