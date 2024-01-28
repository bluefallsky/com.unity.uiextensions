using UnityEngine;
using UnityEngine.UI;
using Gradient = UnityEngine.Gradient;

public class LoopColorAnimation : MonoBehaviour
{
    public Image image;
    public Gradient animationGradient;
    public float duration = 1.0f;
    private float _current;

    public void Update()
    {
        _current += Time.deltaTime;

        var color = animationGradient.Evaluate(_current / duration);
        
        image.color = color;

        if (_current >= duration) _current %= duration;
    }
}
