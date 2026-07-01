using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _startRotate;
    [SerializeField] private Vector3 _endRotate;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void OnValidate()
    {
        if (_startRotate == Vector3.zero)
            _startRotate = transform.eulerAngles;

        if (_endRotate == Vector3.zero)
            _endRotate = transform.eulerAngles + new Vector3(0f, 180f, 0f);
    }

    private void Start()
    {
        transform.DORotate(_endRotate, _duration)
            .From(_startRotate)
            .SetLoops(_loops, _loopType);
    }
}