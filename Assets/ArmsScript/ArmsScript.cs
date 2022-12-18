using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsScript : MonoBehaviour
{
    public bool IsArmed = false;
    private GameObject UmbUnfurl, UmbDefence;
    // Start is called before the first frame update
    void Start()
    {
        UmbDefence = this.gameObject.transform.GetChild(0).gameObject;
        UmbUnfurl = this.gameObject.transform.GetChild(1).gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U)) {
            IsArmed = true;
        } else IsArmed = false;
        
        if (IsArmed) {
            UmbDefence.SetActive(true);
            UmbUnfurl.SetActive(false);
        } else {
            UmbDefence.SetActive(false);
            UmbUnfurl.SetActive(true);
        }
    }
}
