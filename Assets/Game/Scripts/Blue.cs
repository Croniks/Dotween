using UnityEngine;
using DG.Tweening;


internal class Blue : AbstractControlable
{
    public override Tween CreateTween()
    {
        return transform.DOMove(Vector3.left * 4, 2f);
    }
}