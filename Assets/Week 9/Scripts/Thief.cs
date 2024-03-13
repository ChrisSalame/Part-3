using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPointOne;
    public Transform spawnPointTwo;
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(knifePrefab, spawnPointOne.position, spawnPointOne.rotation);
        Instantiate(knifePrefab, spawnPointTwo.position, spawnPointTwo.rotation);
    }

}
