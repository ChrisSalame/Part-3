using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : AquaticAnimal
{
    Coroutine pauseBeforeShell;
    public Sprite[] crabSprite = new Sprite [2];
    protected override void action()
    {
        pauseBeforeShell = StartCoroutine(actionCoroutine());

    }

    IEnumerator actionCoroutine()
    {
        yield return new WaitForSeconds(2);
        GetComponent<SpriteRenderer>().sprite = crabSprite[1];
        Debug.Log("Crab Tucked into Shell");
    }


    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = crabSprite[1];
        action();


    }



}
