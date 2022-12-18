using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class SnakeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sequence seq = DOTween.Sequence();
        Vector3 final = new Vector3(transform.position.x, transform.position.y, transform.position.z) + transform.forward * 10f;
        seq.Append(gameObject.transform.DOMove(final, 0.75f).SetEase(Ease.InSine));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
