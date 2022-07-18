using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;

    private float _coolDawn = 6f;
    private float _timer = 0;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }
    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    public override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }
}
