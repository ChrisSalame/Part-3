using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AquaticAnimal : MonoBehaviour
{
    //This sets the speed
    public float swimSpeed = 0.1f;
    Vector2 swimDirection;
    void Start()
    {
        //This makes it so that the animal doesn't go updward, then the .x sets the swim direction to x
        swimDirection.y = 0;
        swimDirection.x = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        //This has the creature move in a set direction using speed
        transform.Translate(swimDirection.normalized * swimSpeed);
    }

    //This destroys the game object once its offscreen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
