using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WithoutCoroutines : MonoBehaviour
{
    public GameObject missile;
    public float speed = 5;
    public float turningSpeedReduction = 0.75f;
    public float turn = 45;
    public float turnTwo = 90;
    public float time = 0;
    float interpolation = 0;

    void Start()
    {
        
    }

    void Update()
    {
        forward();
    }

    private void OnMouseDown()
    {
        Turn();
        TurnTwo();

    }

    public void Turn()
    {
        Quaternion currentHeading = missile.transform.rotation;
        Quaternion newHeading = currentHeading * Quaternion.Euler(0, 0, turn);
        while (interpolation < 1)
        {
            interpolation += Time.deltaTime;
            missile.transform.rotation = Quaternion.Lerp(currentHeading, newHeading, interpolation);
            missile.transform.Translate(transform.right * (speed * turningSpeedReduction) * Time.deltaTime);
        }
    }
    public void TurnTwo()
    {
        Quaternion currentHeading = missile.transform.rotation;
        Quaternion newHeading = currentHeading * Quaternion.Euler(0, 0, turnTwo);
        while (interpolation < 1)
        {
            interpolation += Time.deltaTime;
            missile.transform.rotation = Quaternion.Lerp(currentHeading, newHeading, interpolation);
            missile.transform.Translate(transform.right * (speed * turningSpeedReduction) * Time.deltaTime);
        }
    }

    public void forward()
    {
        time += Time.deltaTime;
        missile.transform.Translate(transform.right * speed * Time.deltaTime);
    }

}

