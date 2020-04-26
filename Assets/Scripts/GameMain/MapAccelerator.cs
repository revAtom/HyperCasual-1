using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilites;
public class MapAccelerator : Singleton<MapAccelerator>
{
    float maxSpeed = 100, timeZeroMax = 100, accerelationForce;
    
    public float forwardVelocity;

    private new void Awake()
    {
        accerelationForce = maxSpeed / timeZeroMax;
        forwardVelocity = 10f;
    }
    private void Update()
    {
        forwardVelocity += accerelationForce * Time.deltaTime;
        forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);
      
    }
}
