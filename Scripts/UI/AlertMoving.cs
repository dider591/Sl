using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AlertMoving : MonoBehaviour
{
    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _rectTransform.DOJump(new Vector3(250, 2000, 0), 2, 1, 1);
    }
}
