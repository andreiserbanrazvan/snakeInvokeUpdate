using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomly : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float distance = 3.0f;
    public float delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", delay);
    }

    void Spawn()
    {
        Instantiate(objectToSpawn, transform.position + Random.insideUnitSphere * distance, Quaternion.identity);
        Invoke("Spawn", delay);
    }
}
