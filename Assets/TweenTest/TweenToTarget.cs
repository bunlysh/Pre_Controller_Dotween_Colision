using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenToTarget : MonoBehaviour
{
    [SerializeField] Transform _tweenTarget;

    // Start is called before the first frame update
    void Start()
    {
        //DoMovement(_tweenTarget, 10.0f);
        // DoRotate(_tweenTarget, 10.0f);
        //DoPunchScale(new Vector3(1.5f, 1.5f, 1.5f), 1.0f);
        //DoShakePosition(1.0f);
        //DoPunchScaleLooped(new Vector3(1.5f, 1.5f, 1.5f), 1.0f);
    }


    public void DoMovement(Transform inTargetTransform, float inTweenTime)
    {
        transform.DOMove(inTargetTransform.position, inTweenTime);
    }


    public void DoRotate(Transform inTargetTransform, float inTweenTime)
    {
        transform.DORotate(inTargetTransform.eulerAngles, inTweenTime);
    }


    public void DoPunchScale(Vector3 inTargetPunch, float inTweenTime)
    {
        transform.DOPunchScale(inTargetPunch, inTweenTime);
    }


    public void DoShakePosition(float inTweenTime)
    {
        transform.DOShakePosition(inTweenTime);
    }


    public void DoPunchScaleLooped(Vector3 inTargetPunch, float inTweenTime)
    {
        transform.DOPunchScale(inTargetPunch, inTweenTime).SetLoops(-1);
    }
}
