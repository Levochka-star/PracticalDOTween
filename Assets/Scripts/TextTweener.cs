using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextTweener : MonoBehaviour 
{
    [SerializeField] private float _pauseDuration = 3f;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType = LoopType.Restart;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Sequence textSequence = DOTween.Sequence();

        textSequence.Append(_text.DOText("Замена", _duration));
        textSequence.AppendInterval(_pauseDuration);

        textSequence.Append(_text.DOText(", добавление", _duration).SetRelative(true));
        textSequence.AppendInterval(_pauseDuration);

        textSequence.Append(_text.DOText("эффект замены с перебором", _duration, true, ScrambleMode.All));
        textSequence.AppendInterval(_pauseDuration);

        textSequence.SetLoops(_loops, _loopType);
    }
}