using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFire : MonoBehaviour
{
    public GameObject Fire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter() {
        Invoke(nameof(Active), 3f);
        return;
    }
    private void Active() {
        Fire.SetActive(true);
    }
}
