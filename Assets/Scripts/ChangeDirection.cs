using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour {
  public int rotateConst;
  // Start is called before the first frame update
  void Start() {
    rotateConst = 1;
  }

  // Update is called once per frame
  void Update() {
        
  }

  private void OnCollisionEnter(Collision other) {
        Debug.Log("Hit");
    if (other.gameObject.tag == "Player") {
      other.gameObject.transform.Rotate(Vector3.up, rotateConst * -90);
      rotateConst *= -1;
    }
  }
}
