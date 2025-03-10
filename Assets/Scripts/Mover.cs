using DG.Tweening;
using UnityEngine;

public class Mover : Entity
{
    [SerializeField] private Vector3 _targetPosition;

    private void Start()
    {
        transform.DOMove(_targetPosition, Duration).
            SetEase(Ease).
            SetLoops(Repeats, LoopType);
    }        
}