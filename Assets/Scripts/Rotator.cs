using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    float speedRotationMultiplier = 1;
    
    void Update()
    {
        gameObject.transform.Rotate(0, 0, speedRotationMultiplier * Time.deltaTime);
    }
}
