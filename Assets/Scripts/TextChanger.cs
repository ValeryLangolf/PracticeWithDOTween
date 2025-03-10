using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private string _textToReplace;
    [SerializeField] private string _textToAdd;
    [SerializeField] private string _textReplaceBrutForce;

    private Text _text;

    private void Awake() =>
        _text = GetComponent<Text>();

    private void Start()
    {
        _text.DOText(_textToReplace, _duration).OnComplete(() =>
            _text.DOText(_textToAdd, _duration).SetRelative().OnComplete(() =>
                _text.DOText(_textReplaceBrutForce, _duration, true, ScrambleMode.All)));
    }
}