using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlatform : MonoBehaviour
{
    public GameObject forkPrefab;  //1
    public GameObject spoonPrefab; //2
    public GameObject handPrefab; //3

    void Start()
    {
        int randomPlatform = Random.Range(0, 3);
        switch (randomPlatform)
        {
            case 0:
                Instantiate(forkPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            case 1:
                Instantiate(spoonPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            case 2:
                Instantiate(handPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            default:
                break;
        }
    }
}
