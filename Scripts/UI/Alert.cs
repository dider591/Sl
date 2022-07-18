using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    [SerializeField] private GameObject _alertBlinking;
    [SerializeField] private GameObject _alertMoving;
    [SerializeField] private Player _player;
    [SerializeField] private Transform _canvas;

    private void OnEnable()
    {
        _player.Died += OnDied;
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _player.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged()
    {
        if (_player.Heath != 0)
        {
            Instantiate(_alertBlinking, _canvas);
        }
    }

    private void OnDied()
    {
        Instantiate(_alertMoving, _canvas);
    }
}
