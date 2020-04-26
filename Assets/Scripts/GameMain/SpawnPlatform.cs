using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
   public Transform pointTrans;

    public GameObject[] mapPrefabs;
    void Update()
    {
        if(this.gameObject.transform.childCount < 6)
        {
            PlatformSpawner();
        }
    }
    public void PlatformSpawner()
    {
        int i = Random.Range(0, 4);
     GameObject prefab = Instantiate(mapPrefabs[i], pointTrans.position, Quaternion.identity);
        prefab.transform.SetParent(this.transform);
    }
}
