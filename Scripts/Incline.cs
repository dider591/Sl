using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Incline : MonoBehaviour
{
    [SerializeField] private Player _player;

    private int Slant = Animator.StringToHash("slant");

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _player.Died += OnDied;
    }

    private void OnDied()
    {
        _animator.SetBool(Slant, true);
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
    }
}
