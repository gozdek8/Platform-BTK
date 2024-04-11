using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCollider : MonoBehaviour
{
        public GameObject spinningCollider;
        
        public float xAngle, yAngle, zAngele;
        void Awake()
        {
            Transform transformSC = spinningCollider.GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            spinningCollider.transform.Rotate(xAngle,yAngle,zAngele);  
        }

        void Rotate()
        {
            spinningCollider.transform.Rotate(0.0f,0.0f,90.0f,Space.Self);
        }

}
