using DG.Tweening;
using UnityEngine;


public class Red : MonoBehaviour
{
    

    private void Start()
    {
        transform.DOMove(Vector3.up * 2, 2f).SetRelative(true);
    }
}
