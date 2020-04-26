using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpikes : MonoBehaviour
{
    Vector3 spawnVector;

    float randomSpawnRange;

    public GameObject spikePref;
    private void Awake()
    { 
        StartCoroutine(SpikeSpawner());
    }
    IEnumerator SpikeSpawner()
    {
        randomSpawnRange = Random.Range(2, 8);
        spawnVector = new Vector3(transform.position.x,
            transform.position.y, transform.position.z + randomSpawnRange);
        Instantiate(spikePref, spawnVector, Quaternion.identity);
        yield return new WaitForSeconds(1);
        StartCoroutine(SpikeSpawner());
    }
}
