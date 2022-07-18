using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private Rigidbody _topRigidbody;
    [SerializeField] private ParticleSystem _effect;

    private Vector3 _angleRandom;
    private float _reward = 0.1f;
    private float _randomForse;
    private Vector3 _randomTorque;

    private void Start()
    {
        _randomForse = Random.Range(2.3f, 2.9f);
        _randomTorque = new Vector3(Random.Range(100f, 200f), Random.Range(100f, 200f), Random.Range(60f, 80f));
        _angleRandom = new Vector3(1f, Random.Range(2f, 3f), 0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            player.Slice();
            _topRigidbody.isKinematic = false;
            _topRigidbody.AddForce(_angleRandom * _randomForse, ForceMode.Impulse);
            _topRigidbody.AddTorque(_randomTorque);
            Instantiate(_effect, _effect.transform.position, _effect.transform.rotation);
            player.AddScore(_reward);

            Destroy(gameObject, 5);
        }
        if (other.TryGetComponent<EndPoint>(out EndPoint endPoint))
        {
            Destroy(gameObject);
        }
    }
}
