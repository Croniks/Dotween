using UnityEngine;
using DG.Tweening;


internal class Blue : AbstractControlable
{
    public override Tween CreateTween()
    {
        return DOTween.Sequence()
                    .Append(transform.DOMoveY(2f, 1f, true).SetRelative(true))
                    .Append(transform.DOMoveX(-4f, 1f, true).SetRelative(true))
                    .Append(transform.DOMoveY(-4f, 1f, true).SetRelative(true))
                    .Append(transform.DOMoveX(4f, 1f, true).SetRelative(true));
    }
}