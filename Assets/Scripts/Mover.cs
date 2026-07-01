using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void OnValidate()
    {
        if (_startPosition == Vector3.zero)
            _startPosition = transform.position;

        if (_endPosition == Vector3.zero)
            _endPosition = transform.position + new Vector3(0f, 46f, 0f);
    }

    private void Start()
    {
        transform.DOMove(_endPosition, _duration)
            .From(_startPosition)
            .SetLoops(_loops, _loopType);
    }
}