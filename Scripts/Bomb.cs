using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bomb : MonoBehaviour
{
    [SerializeField]private int _damage;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            Destroy(gameObject);
            player.ApplyDamage(_damage);
        }
        if (other.TryGetComponent<EndPoint>(out EndPoint endPoint))
        {
            Destroy(gameObject);
        }
    }
}
