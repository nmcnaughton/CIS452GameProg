using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject smallEnemyPrefab;
    public GameObject largeEnemyPrefab;
    public GameObject bossEnemyPrefab;
    public GameObject shotSpawnLoc;

    public bool gameOn;

    void Start()
    {
    }

    public void BeginGame()
    {
        gameOn = true;
        StartCoroutine(SmallSpawner());
        StartCoroutine(LargeSpawner());
        StartCoroutine(BossSpawner());
    }

    IEnumerator SmallSpawner()
    {
        while(gameOn)
        {
            yield return new WaitForSeconds(Random.Range(.5f, .7f));
            var small = Instantiate(smallEnemyPrefab);
            small.transform.position = new Vector3(Random.Range(-15f, 15f), 15f, 0f);
        }
    }

    IEnumerator LargeSpawner()
    {
        while (gameOn)
        {
            yield return new WaitForSeconds(Random.Range(1f, 2.5f));
            var large = Instantiate(largeEnemyPrefab);
            large.transform.position = new Vector3(Random.Range(-15f, 15f), 15f, 0f);
        }
    }

    IEnumerator BossSpawner()
    {
        while (gameOn)
        {
            yield return new WaitForSeconds(15f);
            var boss = Instantiate(bossEnemyPrefab);
            boss.transform.position = new Vector3(0f, 16f, 0f);
        }
    }

    public void SpawnShot(float size, int number)
    {
        StartCoroutine(Spawning(size, number));
    }

    IEnumerator Spawning(float size, int number)
    {
        for (int i = 0; i < number; i++)
        {
            var tempBullet = Instantiate(bulletPrefab, shotSpawnLoc.transform.position, shotSpawnLoc.transform.rotation);
            tempBullet.transform.localScale *= size;
            yield return new WaitForSeconds(.125f);
        }
    }
}
