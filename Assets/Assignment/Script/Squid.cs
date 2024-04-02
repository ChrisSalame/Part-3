using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squid : AquaticAnimal
{
    public GameObject ink;
    Coroutine pauseBeforeSquidInk;
    public Vector2 inkDirection;
    public float inkSpawn = 0;

    void inkSpeed() 
    {
        inkDirection.y = -1;
        inkDirection.x = 0; 
    }

    protected override void action()
    {
        pauseBeforeSquidInk = StartCoroutine(actionCoroutine());

    }

    IEnumerator actionCoroutine()
    {
        while (inkSpawn <=3)  
        {
            inkSpawn++;
            yield return new WaitForSeconds(0.5f);
            Instantiate(ink);
            Debug.Log(inkSpawn);
            transform.Translate(inkDirection.normalized * swimSpeed);
        }
       inkSpawn = 0;
        Debug.Log("Squid shot out ink");

    }


    private void OnMouseDown()
    {
        action();
    }
}
