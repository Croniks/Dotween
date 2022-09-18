using DG.Tweening;
using UnityEngine;


internal abstract class AbstractControlable : MonoBehaviour
{
    protected Tween tween;


    private void Start()
    {
        tween = CreateTween();
        tween.SetAutoKill(false);
        tween.Pause();
    }

    public virtual void PlayForward()
    {
        tween.PlayForward();
    }

    public virtual void PlayBackwards()
    {
        tween.PlayBackwards();
    }

    public abstract Tween CreateTween();
}