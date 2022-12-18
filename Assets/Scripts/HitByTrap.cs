using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class HitByTrap : MonoBehaviour
{
    public PlayerController playerController;
    public bool isBack = false;
    // Start is called before the first frame update
    void Start() {} 

    // Update is called once per frame
    void Update(){
        //Debug.Log(transform.position.z);
        /*
        if(isBack){
            // Vector3 v = new Vector3(0, upV, 0) - transform.forward;
            Vector3 v = (-transform.forward + transform.up).normalized * 0.1f;
            GetComponent<Rigidbody>().AddForce(v, ForceMode.Impulse);
            Invoke(nameof(f), 3f);
            // isBack = false;
            
            // Sequence seq = DOTween.Sequence();
            // seq.Append(gameObject.transform.DOMove(new Vector3(0, 1.8f, 1f), 0.75f).SetEase(Ease.Linear))
            // .Append(gameObject.transform.DOMove(new Vector3(0, 1.582f, 2), 0.1f).SetEase(Ease.Linear).OnComplete(() => {isBack = false;}));
            
        }
        */
    }
        
    private void OnTriggerEnter(Collider collision) {
        Debug.Log(collision.name);
        if (collision.gameObject.tag == "Trap" && !isBack) {
            Debug.Log("Die");
            isBack = true;
            //Vector3 pos = transform.position;
            //pos -= transform.forward * 1000;

            Sequence seq = DOTween.Sequence();

            Vector3 final = new Vector3(transform.position.x, transform.position.y, transform.position.z) + transform.forward * (-5);
            Vector3 mid = new Vector3(transform.position.x, transform.position.y, transform.position.z) + (-transform.forward) + transform.up;
            seq
            .Append(gameObject.transform.DOMove(mid, 0.75f).SetEase(Ease.Linear))
            .Append(gameObject.transform.DOMove(final, 0.1f).SetEase(Ease.Linear).OnComplete(() => {isBack = false;}));
        }
    }
}
