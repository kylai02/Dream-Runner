using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UB.Simple2dWeatherEffects.Standard;

public class GameManager : MonoBehaviour {
  public GameObject player;
  public TextMeshProUGUI keyNumUI;
  public D2FogsPE darkFog;
  public D2FogsPE lightFog;
  public float FogOutTime;
  private float defaultFogOutTime;
  
  public int keyNum;
  // Start is called before the first frame update
  void Start() {
    keyNum = 0;
    defaultFogOutTime = FogOutTime;
    darkFog.Density = 2.51f;
    lightFog.Density = 1.42f;
  }

  // Update is called once per frame
  void Update() {
    FogIn();
    FogOut();
  }

  public void GetAKey() {
    keyNum++;
    keyNumUI.text = (keyNum).ToString();
  }

  private void FogIn() {
    float y = player.transform.position.y;

    if (y - 68.3 > 0) {
      darkFog.Density = 2.51f * ((y - 68.3f) / (93.7f - 68.3f));
      lightFog.Density = 1.42f * ((y - 68.3f) / (93.7f - 68.3f));
    }
  }

  private void FogOut() {
    FogOutTime -= Time.deltaTime;

    if (FogOutTime > 0) {
      darkFog.Density = 2.51f * (FogOutTime / defaultFogOutTime);
      lightFog.Density = 1.42f * (FogOutTime / defaultFogOutTime);
    }
  }
}
