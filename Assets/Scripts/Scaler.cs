using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _startScale;
    [SerializeField] private Vector3 _endScale;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void OnValidate()
    {
        if (_startScale == Vector3.zero)
            _startScale = transform.localScale;

        if (_endScale == Vector3.zero)
            _endScale = transform.localScale + new Vector3(25f, 25f, 25f);
    }


    private void Start()
    {
        transform.DOScale(_endScale, _duration)
            .From(_startScale)
            .SetLoops(_loops, _loopType);
    }
}