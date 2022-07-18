using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private GameObject _foodsConveyor;
    [SerializeField] private GameObject _housesConveyor;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.Died += OnDied;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
    }

    private void OnDied()
    {
        _foodsConveyor.SetActive(false);
        _housesConveyor.SetActive(false);
    }
}
