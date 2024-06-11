using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlatform : MonoBehaviour
{
    
    public GameObject forkPrefab;  //0
    public GameObject spoonPrefab; //1
    public GameObject handPrefab; //2
    public GameObject startPlatform;

    public List<GameObject> platforms = new List<GameObject>();

    public Transform movingPlatform;

    public MovePlatform movePlatform;

    int offset = 0;

    void Awake()
    {
        
        int randomPlatform = Random.Range(0, 3);
        switch (randomPlatform)
        {
            case 0:
                GameObject forkPlatform = Instantiate(forkPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                forkPlatform.transform.SetParent(movingPlatform, false);
                platforms.Add(forkPlatform);
                break;
            case 1:
                GameObject spoonPlatform = Instantiate(spoonPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                spoonPlatform.transform.SetParent(movingPlatform, false);
                platforms.Add(spoonPlatform);
                break;
            case 2:
                GameObject handPlatform = Instantiate(handPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                handPlatform.transform.SetParent(movingPlatform, false);
                platforms.Add(handPlatform);
                break;
            default:
                break;
        }
    }

    void Start()
    {
        StartCoroutine(SpawnAndCooldown());
    }

    IEnumerator SpawnAndCooldown()
    {
        while (true)
        {
            yield return new WaitForSeconds(.75f);
            int randomPlatform = Random.Range(0, 3);
            switch (randomPlatform)
            {
                case 0:
                    GameObject forkPlatform = Instantiate(forkPrefab, new Vector3((offset += 15), 0, 0), Quaternion.identity);
                    forkPlatform.transform.SetParent(movingPlatform, false);
                    platforms.Add(forkPlatform);
                    break;
                case 1:
                    GameObject spoonPlatform = Instantiate(spoonPrefab, new Vector3((offset += 15), 0, 0), Quaternion.identity);
                    spoonPlatform.transform.SetParent(movingPlatform, false);
                    platforms.Add(spoonPlatform);
                    break;
                case 2:
                    GameObject handPlatform = Instantiate(handPrefab, new Vector3((offset += 15), 0, 0), Quaternion.identity);
                    handPlatform.transform.SetParent(movingPlatform, false);
                    platforms.Add(handPlatform);
                    break;
                default:
                    break;
            }

            

        }
        
    }

}
