using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionObstaculo : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;

    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0.0f);
    }
}
