using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverByCloud : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    private void OnTriggerEnter(Collider collision) {
        if (collision.tag == "Cloud") {
            Debug.Log("Die");
        GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
        }

    }
}
