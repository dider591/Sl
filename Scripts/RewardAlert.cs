using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardAlert : MonoBehaviour
{
    [SerializeField] private GameObject _rewardImage;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.ScoreChanged += OnScoreChanged;
    }

    private void OnScoreChanged(float score)
    {
        Instantiate(_rewardImage, _player.transform.position, _player.transform.rotation);
    }

    private void OnDisable()
    {
        _player.ScoreChanged -= OnScoreChanged;
    }
}

