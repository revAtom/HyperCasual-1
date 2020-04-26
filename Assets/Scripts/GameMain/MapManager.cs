using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    void Update()
    {
        float speed = MapAccelerator.instance.forwardVelocity;
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mapDeletor")
        {
            Destroy(this.gameObject);
        }
    }
}
