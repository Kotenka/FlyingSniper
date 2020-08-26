using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Enemy;
    public float TimeSpawn;


    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Enemy, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
