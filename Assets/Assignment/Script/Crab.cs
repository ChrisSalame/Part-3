using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : AquaticAnimal
{
    Coroutine pauseBeforeShell;
    public Sprite[] crabSprite = new Sprite [2];
    protected override void action()
    {
        swimSpeed = 0;
        pauseBeforeShell = StartCoroutine(actionCoroutine());
        
    }

    IEnumerator actionCoroutine()
    {
        yield return new WaitForSeconds(3);
        swimSpeed = 0.1f;
        GetComponent<SpriteRenderer>().sprite = crabSprite[0];
        Debug.Log("Crab go out of shell");
    }


    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = crabSprite[1];
        action();


    }



}
