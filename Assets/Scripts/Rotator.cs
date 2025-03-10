using DG.Tweening;
using UnityEngine;

public class Rotator : Entity
{
    [SerializeField] private Vector3 _targetRotation;

    private void Start()
    {
        transform.DORotate(transform.localEulerAngles + _targetRotation, Duration).
            SetEase(Ease).
            SetLoops(Repeats, LoopType);
    }
}