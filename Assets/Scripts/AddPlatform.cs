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

    public float rate;

    int offset = 0;
    int theSecondTime = 0;




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

    void Update()
    {
        rate = (movePlatform.speed + 10f) / 2; 
    }

    IEnumerator SpawnAndCooldown()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
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
            theSecondTime++;

            if (theSecondTime != 1)
            {
                int indexToDestroy = theSecondTime - 2;

                if (indexToDestroy >= 0 && indexToDestroy < platforms.Count)
                {
                    Destroy(platforms[indexToDestroy]);
                }
            }

        }
        
    }
}
