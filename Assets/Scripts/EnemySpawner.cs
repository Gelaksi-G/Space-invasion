using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;
    public Transform st;
    public GameObject spavn_effect;

    private float timeSpawn;
    public float startTimeSpawn;

    void Update()
    {
        float randomRotation = Random.Range(0f, 360f);
        Quaternion rot = Quaternion.Euler(new Vector3(0, 0, randomRotation));
        if (timeSpawn <= 0)
        {
            Instantiate(enemy, spawnPoint.position, rot).transform.SetParent(st);
            Instantiate(spavn_effect, transform.position, transform.rotation).transform.SetParent(st);
            timeSpawn = startTimeSpawn;
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}
