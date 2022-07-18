using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AlertBlinking : MonoBehaviour
{
    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _rectTransform.DOPunchScale(new Vector3(2, 2, 0), 1, 3, 5);
        Destroy(gameObject, 1);
    }
}
