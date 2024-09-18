using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    Object_Pooler objectPooler;
    private void Start()
    {
        objectPooler = Object_Pooler.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objectPooler.SpawnFromPool("Sphere", transform.position, Quaternion.identity);
    }
}
