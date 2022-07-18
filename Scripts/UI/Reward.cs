using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{

    [SerializeField] private Player _player;
    [SerializeField] private GameObject _reward;
    [SerializeField] private Transform _canvas;

    private void OnEnable()
    {
        _player.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _player.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(float score)
    {
        Instantiate(_reward, _canvas);
    }
}
