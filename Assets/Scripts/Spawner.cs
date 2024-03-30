using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform SpawnPoint;

    void Start()
    {
        Invoke("Spawn", 5);
    }

    public void Spawn()
    {
        Instantiate(enemy, SpawnPoint.position, SpawnPoint.rotation);
    }
}
