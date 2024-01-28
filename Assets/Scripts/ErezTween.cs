using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErezTween : MonoBehaviour
{
    public Transform Transform;


    // Start is called before the first frame update
    void Start()
    {
        Transform.DOMoveZ(-17f, 5f, true).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
