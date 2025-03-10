using DG.Tweening;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    protected float Duration => _duration;

    protected int Repeats => _repeats;

    protected LoopType LoopType => _loopType;

    protected Ease Ease => _ease;
}