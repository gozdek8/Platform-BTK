using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpinningGround : MonoBehaviour
{
    public GameObject spinningGround;

    public float xAngle, yAngle, zAngele;
    // Start is called before the first frame update
    void Awake()
    {
        Transform transformSG = spinningGround.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
      spinningGround.transform.Rotate(xAngle,yAngle,zAngele);  
    }

    void Rotate()
    {
        spinningGround.transform.Rotate(0.0f,0.0f,90.0f,Space.Self);
    }

}
