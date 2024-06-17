using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastInfo : MonoBehaviour
{
    public Movements movements;
    public float offsetDistance;

    void Update()
    {

        
        Vector2 rayDirection = Vector2.right;
        float rayDistance = 10f;
        Vector2 rayOrigin = (Vector2)transform.position + rayDirection.normalized * offsetDistance;

        Debug.DrawRay(rayOrigin, rayDirection * 10, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, rayDirection, rayDistance);

        if (hit.collider.gameObject.name != null)
        {
            Debug.Log(hit.collider.gameObject.name);
        }

        if (hit.collider.gameObject.name == "Hand Sprite" && movements.powered == true)
        {
            hit.collider.gameObject.SetActive(false);
        }
    }
}
