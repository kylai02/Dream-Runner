using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("set1", 2f);
        Invoke("set2", 4f);
        // Invoke("set3", 6f);
        Invoke("set4", 6f);
        Invoke("set5", 8f);
        Invoke("set6", 10f);
        Invoke("closeall", 12f);
    }

    // Update is called once per frame
    void Update(){}
    void set1 () {
        close(0);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
  void set2()
  {
    close(1);
    gameObject.transform.GetChild(1).gameObject.SetActive(true);
  }
  void set3()
  {
    close(2);
    gameObject.transform.GetChild(2).gameObject.SetActive(true);
  }
  void set4()
  {close(3);
    gameObject.transform.GetChild(3).gameObject.SetActive(true);
  }
  void set5()
  {close(4);
    gameObject.transform.GetChild(4).gameObject.SetActive(true);
  }
  void set6()
  {close(5);
    gameObject.transform.GetChild(5).gameObject.SetActive(true);
  }
  void close (int k) {
    for (int i = 0; i < 6; ++i) {
        if (i != k) gameObject.transform.GetChild(i).gameObject.SetActive(false);
    }
  }
  void closeall() {
    for (int i = 0; i < 6; ++i) gameObject.transform.GetChild(i).gameObject.SetActive(false);
  }
}
