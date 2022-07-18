using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SwordBroken : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _angleRandom;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _angleRandom = new Vector3(0.5f, 1.5f, -1f);
        _rigidbody.AddForce(_angleRandom * Random.Range(3f, 4f), ForceMode.Impulse);
    }
}
