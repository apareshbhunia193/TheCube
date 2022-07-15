using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] float coinRotationSpeed = 10f;
    
    void Update()
    {
        transform.Rotate(0f, 0f, coinRotationSpeed * Time.deltaTime);
    }
}
