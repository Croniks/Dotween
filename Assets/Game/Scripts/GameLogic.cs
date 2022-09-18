using System.Collections.Generic;

using UnityEngine;


public class GameLogic : MonoBehaviour
{
    [SerializeField] private List<AbstractControlable> _controlables;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _controlables.ForEach(c => c.PlayForward());
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _controlables.ForEach( c => c.PlayBackwards());
        }
    }
}
