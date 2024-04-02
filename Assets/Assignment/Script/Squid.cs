using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squid : AquaticAnimal
{
    Coroutine pauseBeforeSquidInk;
    public float inkSpawn = 0;


    protected override void action()
    {
        pauseBeforeSquidInk = StartCoroutine(actionCoroutine());
    }

    IEnumerator actionCoroutine()
    {
        while (inkSpawn <=3)  
        {
            inkSpawn++;
            Instantiate(ink);
            Debug.Log(inkSpawn);
        }
        yield return new WaitForSeconds(0.5f);
        inkSpawn = 0;
        Debug.Log("Squid shot out ink");

    }


    private void OnMouseDown()
    {
        action();
    }
}
