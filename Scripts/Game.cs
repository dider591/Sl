using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private GameOverScreen _gameOverScreen;

    private void Start()
    {
        Time.timeScale = 1;
        _startScreen.Open();
        _gameOverScreen.Close();
    }

    private void OnEnable()
    {
        _player.Died += OnDied;
        _startScreen.PlayButtonClick += OnPlayButtonClick;
        _gameOverScreen.RestartButtonClick += OnRestartButtonClick;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _startScreen.PlayButtonClick -= OnPlayButtonClick;
        _gameOverScreen.RestartButtonClick -= OnRestartButtonClick;
    }

    public void OnPlayButtonClick()
    {
        _startScreen.Close();
        Time.timeScale = 1;
    }

    public void OnRestartButtonClick()
    {
        _gameOverScreen.Close();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    private void OnDied()
    {
        StartCoroutine(WaitOpenScreen());
    }

    private IEnumerator WaitOpenScreen()
    {
        yield return new WaitForSeconds(2f);
        _gameOverScreen.Open();
        Time.timeScale = 0;
    }
}
