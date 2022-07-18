using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RewardMower : MonoBehaviour
{
    private RectTransform _rectTransform;
    private CanvasGroup _canvasGroup;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _canvasGroup = GetComponent<CanvasGroup>();
        _rectTransform.DOMove(new Vector3(780, 2500, 0), 2);
        _canvasGroup.DOFade(0, 2);
    }
}
