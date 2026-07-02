using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Colorer : MonoBehaviour 
{
    [SerializeField] private Color _startColor = Color.blue;
    [SerializeField] private Color _endColor = Color.red;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _loops = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_endColor, _duration)
            .From(_startColor)
            .SetLoops(_loops, _loopType);
    }
}