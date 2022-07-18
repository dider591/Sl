using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotate;
    [SerializeField] private Player _player;

    private int _angleTiltSword = 90;
    private float _angleRotateSword = 11f;
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_player.Heath > 0)
        {
            if (Input.GetMouseButton(0))
            {
                transform.rotation = Quaternion.Slerp(_transform.rotation, Quaternion.Euler(0, -_angleRotateSword, -_angleTiltSword), Time.deltaTime * _speedRotate);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * _speedRotate);
            }
        }       
    }
}
