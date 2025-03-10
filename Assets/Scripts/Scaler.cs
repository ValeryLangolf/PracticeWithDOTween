using DG.Tweening;
using UnityEngine;

public class Scaler : Entity
{
    [SerializeField] private float _scaleFactor;

    private void Start()
    {
        transform.DOScale(Vector3.one * _scaleFactor, Duration).
            SetEase(Ease).
            SetLoops(Repeats, LoopType);
    }
}