using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {
  public GameObject startMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

  public void StartBtn() {
    startMenu.SetActive(false);
    PlayerPrefs.SetInt("keyNum", 0);
    PlayerPrefs.SetInt("chestNum", 0);
    Debug.Log(PlayerPrefs.GetInt("chestNum"));
  }
}
