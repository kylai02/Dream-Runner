using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
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
  }


}
