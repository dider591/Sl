using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Stickman : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private GameObject _stickmanCut;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            player.Slice();
            player.ColorChanged();
            Destroy(gameObject);
            Instantiate(_stickmanCut, _rigidbody.position, _rigidbody.rotation);
            player.ApplyDamage(_damage);
        }
        if (other.TryGetComponent<EndPoint>(out EndPoint endPoint))
        {
            Destroy(gameObject);
        }
    }
}
