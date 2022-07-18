using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EndPoint>(out EndPoint endPoint))
        {
            Destroy(gameObject);
        }
    }
}
