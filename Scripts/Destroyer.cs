using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void Update()
    {
        Destroy(gameObject, 4);
    }
}
