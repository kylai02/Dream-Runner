using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
  public GameObject player;
  public GameObject camera1;
  public GameObject camera2; 
  public GameObject camera3; 
  public GameObject camera4;
  public int type = 0;

  // Start is called before the first frame update
  void Start() {
    Debug.Log("start");
    // InvokeRepeating(nameof(Change), 3f, 3f);s
  }

  // Update is called once per frame
  void Update() {
    transform.position = new Vector3(
      transform.position.x,
      player.transform.position.y + 27.68f,
      transform.position.z
    );
  }

  public void SwitchCamera(int type) {
    camera1.SetActive(false);
    camera2.SetActive(false);
    camera3.SetActive(false);
    camera4.SetActive(false);

    if (type == 0) camera1.SetActive(true);
    else if (type == 1) camera2.SetActive(true);
    else if (type == 2) camera3.SetActive(true);
    else if (type == 3) camera4.SetActive(true);

    type = (type + 1) % 4;
  }
}
