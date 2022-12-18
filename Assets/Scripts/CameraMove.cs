using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
  public GameObject player;
    // Start is called before the first frame update
  void Start() {}

    // Update is called once per frame
  void Update() {
    transform.position = new Vector3(
      transform.position.x, 
      player.transform.position.y + 11.75f, 
      transform.position.z
    );

    // if (player.transform.position.y <= transform.position.y - 7) {
    //   Debug.Log("GameOver");
    // }
  }
}