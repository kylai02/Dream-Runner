using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UB.Simple2dWeatherEffects.Standard;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public GameObject player;
  public TextMeshProUGUI keyNumUI;
  public TextMeshProUGUI chestNumUI;
  public D2FogsPE darkFog;
  public D2FogsPE lightFog;
  public float FogOutTime;
  private float defaultFogOutTime;

  public float changeSceneY;
  [SerializeField]bool changeScene;
  public int nextScene;

  public int keyNum;
  public int chestNum;
  // Start is called before the first frame update
  void Start()
  {
    keyNum = 0;
    chestNum = 0;
    defaultFogOutTime = FogOutTime;
    darkFog.Density = 2.51f;
    lightFog.Density = 1.42f;
  }

  // Update is called once per frame
  void Update()
  {
    FogIn();
    FogOut();

    // if (player.transform.position.y >= changeSceneY)
    // {
    //   if (changeScene)
    //     return;
    //   changeScene = true;
    //   SceneManager.LoadScene(nextScene);
      
    // }
  }

  public void GetAKey()
  {
    keyNum++;
    keyNumUI.text = (keyNum).ToString();
  }

  public void GetAChest()
  {
    chestNum++;
    chestNumUI.text = (chestNum).ToString();
  }

  private void FogIn()
  {
    float y = player.transform.position.y;

    if (y - 68.3 > 0)
    {
      darkFog.Density = 2.51f * ((y - 68.3f) / (93.7f - 68.3f));
      lightFog.Density = 1.42f * ((y - 68.3f) / (93.7f - 68.3f));
    }
  }

  private void FogOut()
  {
    FogOutTime -= Time.deltaTime;

    if (FogOutTime > 0)
    {
      darkFog.Density = 2.51f * (FogOutTime / defaultFogOutTime);
      lightFog.Density = 1.42f * (FogOutTime / defaultFogOutTime);
    }
  }
}
