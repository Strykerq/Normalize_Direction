using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normalize : MonoBehaviour
{
    private float speed = 5f;
    public Vector3 direction = Vector3.forward;

    
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
