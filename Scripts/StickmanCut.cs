using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanCut : MonoBehaviour
{
    [SerializeField] private Rigidbody _topRigidbody;
    [SerializeField] private ParticleSystem _effect;

    private Vector3 _angleRandom;
    private float _reward = 0.1f;
    private float _randomForse;
    private Vector3 _randomTorque;
    private int _delayDestroy = 5;

    private void Awake()
    {
        _randomForse = Random.Range(1f, 1.5f);
        _randomTorque = new Vector3(Random.Range(100f, 200f), Random.Range(100f, 200f), Random.Range(60f, 80f));
        _angleRandom = new Vector3(1f, Random.Range(2f, 3f), 0.5f);
    }

    private void Start()
    {
        _topRigidbody.isKinematic = false;
        _topRigidbody.AddForce(_angleRandom * _randomForse, ForceMode.Impulse);
        _topRigidbody.AddTorque(_randomTorque);
        Instantiate(_effect, _effect.transform.position, _effect.transform.rotation);
        Destroy(gameObject, _delayDestroy);
    }
}
