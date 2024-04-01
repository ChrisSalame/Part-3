using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class AquaticAnimal : MonoBehaviour
{
    //This sets the speed
    public float swimSpeed = 0.1f;
    Vector2 swimDirection;

    
    Rigidbody2D animalRb;

    void Start()
    {
        //This makes it so that the animal doesn't go updward by setting y to 0, then the .x sets the swim direction to x
        swimDirection.y = 0;
        swimDirection.x = 1;

        animalRb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }

    private void FixedUpdate()
    {
        //This has the creature move in a set direction using speed
        transform.Translate(swimDirection.normalized * swimSpeed);
    }



    //This function is to have the animal perform an action when pressed on 
    protected virtual void action() 
    {

    }


    //This destroys the game object once its offscreen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
