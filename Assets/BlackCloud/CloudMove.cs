using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    private float MoveSpeed = 0.04f;
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, MoveSpeed, 0);
    }
}
