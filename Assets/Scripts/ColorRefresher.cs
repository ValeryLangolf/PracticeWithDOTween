using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorRefresher : Entity
{
    [SerializeField] private Color _targetColor;

    private Material _material;

    private void Awake()
    {
        Renderer renderer = GetComponent<Renderer>();
        _material = renderer.material;
    }

    private void Start()
    {
        _material.DOColor(_targetColor, Duration).SetEase(Ease).
        SetLoops(Repeats, LoopType);
    }
}