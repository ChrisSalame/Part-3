using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class BuildingStallCode : MonoBehaviour
{
    Coroutine building;

    public Transform buildingPartStartPositionOne;
    public Transform buildingPartStartPositionTwo;
    public Transform buildingPartStartPositionThree;
    public Transform buildingPartStartPositionFour;

    public GameObject buildingPartOne;
    public GameObject buildingPartTwo;
    public GameObject buildingPartThree;
    public GameObject buildingPartFour;

    Vector3 buildingPartEndPosition = new Vector3(1f,1f, 0);
    public AnimationCurve buildingContructCurve;
    public float buildLerpSpeed;
    public float buildingLerpInter = 1f;

    protected void Start()
    {
        if (building != null)
        {
            StopCoroutine(building);
        }
        building = StartCoroutine(build());
    }



    IEnumerator build()
    {
        while (buildLerpSpeed < 1)
        {
            yield return null;
        }
        Debug.Log("code works");

        buildingLerpInter = buildingContructCurve.Evaluate(buildLerpSpeed);

        yield return new WaitForSeconds(1f);
        buildingPartOne.transform.localScale = Vector3.Lerp(buildingPartStartPositionOne.position, buildingPartEndPosition, buildingLerpInter);
        Debug.Log("build one complete");
        yield return new WaitForSeconds(1f);
        buildingPartTwo.transform.localScale = Vector3.Lerp(buildingPartStartPositionTwo.position, buildingPartEndPosition, buildingLerpInter);
        Debug.Log("build two complete");
        yield return new WaitForSeconds(1f);
        buildingPartThree.transform.localScale = Vector3.Lerp(buildingPartStartPositionThree.position, buildingPartEndPosition, buildingLerpInter);
        buildingPartFour.transform.localScale = Vector3.Lerp(buildingPartStartPositionThree.position, buildingPartEndPosition, buildingLerpInter);
        Debug.Log("build three complete");
        Debug.Log("build Four complete");
    }
   
}
