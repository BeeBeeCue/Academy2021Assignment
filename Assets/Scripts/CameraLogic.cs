using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraLogic : MonoBehaviour
{

    CinemachineCollider cc;
    Vector3 cameraPositionY;
    float minY;
    Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CinemachineCollider>();
        minY = cameraPositionY.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPositionY = new Vector3(0, gameObject.transform.position.y, 0);

        if (minY > cameraPositionY.y)
        {
            minY = cameraPositionY.y;
           //Debug.Log("if");
        }
        else
        {
            this.transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minY, transform.position.y), transform.position.z);

        }

    }
}
