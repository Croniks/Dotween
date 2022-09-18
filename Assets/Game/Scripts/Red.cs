using DG.Tweening;
using UnityEngine;


internal class Red : AbstractControlable
{
    public override Tween CreateTween()
    {
        return transform.DOMove(Vector3.up * 2, 2f);
    }
}
