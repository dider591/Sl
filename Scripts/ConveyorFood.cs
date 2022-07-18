using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorFood : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            return;
        }
        else
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, _endPoint.position, _speed * Time.deltaTime);
        }
    }
}
