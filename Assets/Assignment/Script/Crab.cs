using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : AquaticAnimal
{
    Coroutine pauseBeforeShell;
    public Sprite[] crabSprite;
    protected override void action()
    {
        GetComponent<SpriteRenderer>().sprite = crabSprite[0];
        pauseBeforeShell = StartCoroutine(actionCoroutine());

    }

    IEnumerator actionCoroutine()
    {
        GetComponent<SpriteRenderer>().sprite = crabSprite[1];
        yield return new WaitForSeconds(1);
        Debug.Log("Crab Tucked into Shell");
    }


    private void OnMouseDown()
    {
        action();
    }



}
