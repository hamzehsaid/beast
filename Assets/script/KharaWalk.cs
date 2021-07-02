using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class KharaWalk : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;

    float speed;
    
    void Start()
    {
    khayal
        speed = Random.Range(minSpeed,maxSpeed);
    }

    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);    
    }
}
