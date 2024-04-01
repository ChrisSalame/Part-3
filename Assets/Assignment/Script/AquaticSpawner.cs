using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquaticSpawner : MonoBehaviour
{
    public GameObject[] creaturePrefab = new GameObject[3];
    
    
    void Update()
    {
        if (Input.GetKeyDown("space")) 
        {
            Debug.Log("space works and spawner spawns");
            Instantiate(creaturePrefab[Random.Range(0,3)]);
        }
        
    }
}
