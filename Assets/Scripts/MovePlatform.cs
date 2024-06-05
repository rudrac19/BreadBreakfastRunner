using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{

    [Range(1, 10)]
    public float speed;
    

    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x -= (speed / 100) + Time.deltaTime;

        transform.position = newPosition;

    }



}
