using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : AquaticAnimal
{
   

    protected override void action()
    {
        swimSpeed = 0.3f;
        Vector2 swimDirection = new Vector2(Random.Range(-2f,2f), Random.Range(2f,2f));
    }

}
