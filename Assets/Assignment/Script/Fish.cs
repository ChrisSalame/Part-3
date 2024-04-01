using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fish : AquaticAnimal
{
    Coroutine pauseBeforeAction;

    protected override void action()
    {
        StartCoroutine(actionCoroutine());
        swimSpeed = 0.3f;
        Vector2 swimDirection = new Vector2(Random.Range(0f,3f), Random.Range(0f,3f));
        
    }

    IEnumerator actionCoroutine()
    {
        yield return new WaitForSeconds(5);
    }


    private void OnMouseDown()
    {
        action();
    }
}
