using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(MeshRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private GameObject _brokenSword;
    [SerializeField] private Color _colorSword;
    [SerializeField] private Mesh _targetMesh;

    private float _score;
    private Rigidbody _rigidbody;
    private MeshFilter _currentMesh;
    private MeshRenderer _meshRenderer;
    private Animator _animator;

    private int Ñutting = Animator.StringToHash("cutting");

    public int Heath => _health;

    public event UnityAction<float> ScoreChanged;
    public event UnityAction HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        _currentMesh = GetComponent<MeshFilter>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    public void AddScore(float score)
    {
        _score += score;
        ScoreChanged.Invoke(_score);
    }
    
    public void ApplyDamage(int damage)
    {
        int minValueHealth = 1;

        _health -= damage;
        HealthChanged?.Invoke();

        if (_health <= minValueHealth)
        {
            SubstituteSwoprd();
        }
        if (_health <= 0)
        {
            Died?.Invoke();
            ThrowsSword();
        }
    }

    public void ThrowsSword()
    {
        Instantiate(_brokenSword, _rigidbody.transform.position, _brokenSword.transform.rotation);
        Destroy(gameObject);
    }

    public void ColorChanged()
    {
        int minValueFlashing = 3;
        int minValueChange = 2;

        if (_health >= minValueFlashing)
        {
        _meshRenderer.materials[1].DOColor(_colorSword, 0.2f).From();
        }
        if (_health <= minValueChange)
        {
            _meshRenderer.materials[1].DOColor(_colorSword, 0.1f);
        }
    }

    public void Slice()
    {
        _animator.Play(Ñutting);
    }

    private void SubstituteSwoprd()
    {
        _currentMesh.mesh = _targetMesh;
    }
}
