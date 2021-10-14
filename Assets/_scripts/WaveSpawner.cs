using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [Tooltip("prefab de los enemigos a generar")]
    public GameObject prefab;

    [Tooltip("tiempo para empezar y para terminar la oleada")]
    public float startTime, endTime;

    [Tooltip("tiempo entre generacion de enemigos")]
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemies", startTime, spawnRate);
        Invoke("CancelInvoke",endTime);
    }

    void SpawnEnemies()
    {
       //Quaternion q = Quaternion.Euler(0, transform.rotation.eulerAngles.y + Random.Range(-45, 45), 0);


        Instantiate(prefab, transform.position, transform.rotation);
    }
}
