using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

using UnityEngine;


public class Blue : MonoBehaviour
{


    private void Start()
    {
        transform.DOMove(Vector3.left * 4, 2f).SetRelative();
    }
}