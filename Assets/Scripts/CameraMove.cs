using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
  public GameObject player;
  public float speed;
    // Start is called before the first frame update
  void Start() {}

    // Update is called once per frame
  void Update() {
    transform.position = new Vector3(
      transform.position.x, 
      transform.position.y + speed * Time.deltaTime, 
      transform.position.z
    );

    if (player.transform.position.y <= transform.position.y - 7) {
      Debug.Log("GameOver");
    }
  }
}