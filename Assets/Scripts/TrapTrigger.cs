using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject Trap;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }
    
    private void OnTriggerEnter() {
        Trap.SetActive(true);
    }
}
