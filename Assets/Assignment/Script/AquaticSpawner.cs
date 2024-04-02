using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquaticSpawner : MonoBehaviour
{
    //This is creating a list
    public GameObject[] creaturePrefab = new GameObject[3];
    
    
    void Update()
    {
        // This makes it so that when the down key is pressed, the player spawns one of the random prefabs
        if (Input.GetKeyDown("space")) 
        {
            Debug.Log("space works and spawner spawns");
            Instantiate(creaturePrefab[Random.Range(0,3)]);
        }
        
    }
}
