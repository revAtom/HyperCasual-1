using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public TimeManager restartFunc;

    private Rigidbody playerRb;

    int lives = 3;

    float speedForcce = 300, jumpForce = 700;

    private ParticleSystem particle;
    private void Awake()
    {
        particle = GameObject.FindGameObjectWithTag("particle").GetComponent<ParticleSystem>();
        playerRb = GetComponent<Rigidbody>(); 
    }
    void FixedUpdate()
    {       
            if (Input.GetMouseButton(0))
            {
                playerRb.velocity = Vector3.forward * Time.fixedDeltaTime * speedForcce;
            }

            if (Input.GetMouseButton(1))
            {
                playerRb.velocity = Vector3.back * Time.fixedDeltaTime * speedForcce;
            }      
    }
    void OnTriggerEnter(Collider other1)
    {
        if (other1.gameObject.tag == "spikeTag")
        {
            lives--;
            particle.Play();
        }
        

        if (lives <= 0)
        {
            StartCoroutine(restartFunc.SlowMotion());
        }
    }
        void OnTriggerStay(Collider other2)
        {
            if (other2.gameObject.tag == "Jump")
            playerRb.velocity = Vector3.up * jumpForce * Time.deltaTime;          
        }
}
