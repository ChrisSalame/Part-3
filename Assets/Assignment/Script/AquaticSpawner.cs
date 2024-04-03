using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquaticSpawner : MonoBehaviour
{
    //This is creating a list
    public GameObject[] creaturePrefab = new GameObject[3];

  
   
    float timePassed = 0;
    float randomTimer = 0; 

    void Update()
    {
        randomTimer = Random.Range(2, 5);
        timePassed += Time.deltaTime;
        if (timePassed >= randomTimer)
        {
            SpawnCreature();
            timePassed = 0;
        }
    }

    public void SpawnCreature()
    {
        Instantiate(creaturePrefab[Random.Range(0, 3)]);
    }



}
