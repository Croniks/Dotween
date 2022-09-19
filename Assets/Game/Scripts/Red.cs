using System;

using DG.Tweening;
using UnityEngine;


internal class Red : AbstractControlable
{
    private Tweener timer;

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            LaunchTimer(30, 10);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            LaunchTimer(40, 10);
        }
    }

    public override Tween CreateTween()
    {   
        return transform.DOMove(Vector3.up * 2, 2f);
    }

    private void LaunchTimer(int seconds, int warningTime = 0)
    {
        if(seconds < 0) return;

        if (timer == null)
        {
            bool wasWarning = false;
            int previousSeconds = -1;

            timer = DOVirtual.Int(seconds, 0, seconds, (seconds) =>
            {
                if (wasWarning == false && warningTime > 0f && seconds - warningTime <= 0f)
                {
                    wasWarning = true;
                    Debug.Log($"Осталось {seconds} секунд !!!");
                }

                if(previousSeconds != seconds)
                {
                    if (seconds > 0)
                    {
                        Debug.Log(TimeSpan.FromSeconds(seconds).ToString("mm':'ss"));
                    }
                    if (seconds <= 0)
                    {
                        Debug.Log(TimeSpan.FromSeconds(0).ToString("mm':'ss"));
                    }

                    previousSeconds = seconds;
                }
            }).SetAutoKill(false).SetEase(Ease.Linear);
        }
        else
        {
            timer.ChangeValues(seconds, 0, seconds);
            timer.Restart();
        }
    }
}