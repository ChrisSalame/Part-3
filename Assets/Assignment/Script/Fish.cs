using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fish : AquaticAnimal
{
    Coroutine pauseBeforeAction;

    protected override void action()
    {
        pauseBeforeAction = StartCoroutine(actionCoroutine());
        
    }

    IEnumerator actionCoroutine()
    {
        yield return new WaitForSeconds(1);
        swimSpeed = 0.2f;
        Vector2 swimDirection = new Vector2(Random.Range(0f, 2f), Random.Range(0f, 5f));
        Debug.Log("Fish swap faster");
    }


    private void OnMouseDown()
    {
        action();
        ScoreKeeping.score = ScoreKeeping.score + 2;
    }
}
