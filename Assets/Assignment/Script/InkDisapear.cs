using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkDisapear : MonoBehaviour
{

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
