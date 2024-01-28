using UnityEngine;
using UnityEngine.UI.Extensions;

public class Gradient2OptimizeLoopAnimation : MonoBehaviour
{
    public Gradient2Optimized target;
    public float duration = 1.0f;
    public AnimationCurve curve;
    private float _current;

    public void Update()
    {
        _current += Time.deltaTime;

        var offset = curve.Evaluate(_current / duration);

        target.Offset = Mathf.Lerp(-1f, 1f, offset);
        target.Zoom = Mathf.Lerp(0.1f, 10f, offset);

        if (_current >= duration) _current %= duration;
    }
}