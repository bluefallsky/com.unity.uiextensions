using UnityEngine;
using UnityEngine.UI.Extensions;

public class Gradient2LoopAnimation : MonoBehaviour
{
    public Gradient2 target;
    public float duration = 2.0f;
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