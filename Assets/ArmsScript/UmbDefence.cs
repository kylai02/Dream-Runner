using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class UmbDefence : MonoBehaviour
{
    [Header("Player")]
    public GameObject player;
    public HitByTrap hitByTrap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider) {
        Debug.Log("Kill trap");
        if (collider.tag == "Trap") {
            player.GetComponent<Collider>().enabled = false;
            hitByTrap.isBack = true;
        
            Sequence seq = DOTween.Sequence();
            Vector3 PlayerPos = player.transform.position;

            // Vector3 mid = new Vector3(PlayerPos.x, PlayerPos.y, PlayerPos.z) + (-player.transform.forward) + player.transform.up;
            Vector3 final = new Vector3(PlayerPos.x, PlayerPos.y, PlayerPos.z) + player.transform.forward * (-5);
            seq
            // .Append(player.transform.DOMove(mid, 0.75f).SetEase(Ease.Linear))
            .Append(player.transform.DOMove(final, 0.75f).SetEase(Ease.Linear));
            Destroy(collider.gameObject);
            Invoke(nameof(FalseIsBack), 3f);
            player.GetComponent<Collider>().enabled = true;
        }
    }
    private void FalseIsBack() {
        Debug.Log("FalseIsBack");
        hitByTrap.isBack = false;
    }
}
