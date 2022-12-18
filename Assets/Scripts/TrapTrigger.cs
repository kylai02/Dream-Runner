using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject TargetTrap;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }
    
    private void OnTriggerEnter() {
        Invoke(nameof(TrapActive), 2f);
    }

    private void TrapActive() {
        // Debug.Log(TargetTrap.name);
        TargetTrap.SetActive(true);
    }
}
