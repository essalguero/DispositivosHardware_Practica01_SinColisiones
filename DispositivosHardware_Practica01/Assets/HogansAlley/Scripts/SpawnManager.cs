using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public Transform[] spawnPoints;

    public GameObject[] prefabs;

    const float MIN_WAITING_TIME = 4f;
    const float MAX_WAITING_TIME = 10f;


    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnPerson());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Hace spawn de un personaje
    IEnumerator SpawnPerson()
    {
        

        while(true)
        {
            yield return new WaitForSeconds(Random.Range(MIN_WAITING_TIME, MAX_WAITING_TIME));
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);
        }
    }
}
