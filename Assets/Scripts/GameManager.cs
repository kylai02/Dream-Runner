using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
  public TextMeshProUGUI keyNumUI;
  
  public int keyNum;
  // Start is called before the first frame update
  void Start() {
    keyNum = 0;
  }

  // Update is called once per frame
  void Update() {
        
  }

  public void GetAKey() {
    keyNum++;
    keyNumUI.text = (keyNum).ToString();
  }
}
