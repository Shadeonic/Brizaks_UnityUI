using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutSpawnerScript : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float spawnInterval = 1f;
    float minPoz, maxPoz;
    Transform ovenPozition;

    private void Start()
    {
        ovenPozition = GetComponent<Transform>();
    }

    public void BakeDonut(bool state)
    {
        if (state)
            StartCoroutine(BakeDonut());

        else
            StopAllCoroutines();
    }

    IEnumerator BakeDonut()
    {
        while (true)
        {
            minPoz = ovenPozition.position.x - 30f;
            maxPoz = ovenPozition.position.x + 30f;

            float randomX = Random.Range(minPoz, maxPoz);
            Vector2 spawnPosition = 
               new Vector2(randomX, ovenPozition.position.y);

            GameObject donut = 
            Instantiate(donutPrefabs[Random.Range(0, donutPrefabs.Length)], 
            spawnPosition, Quaternion.identity, ovenPozition);

            yield return new WaitForSeconds(spawnInterval);

            // Iznīcina objektu pēc laika
           // Destroy(gameObject, 5f);
        }
    }

}
