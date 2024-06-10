using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public AddPlatform addPlatform;

    void Start()
    {
        StartCoroutine(PlatformDestroy());
    }


    IEnumerator PlatformDestroy()
    {
        while (true)
        {
            yield return new WaitForSeconds(20f);

            GameObject urGonnaBeDestryedBuddy = addPlatform.platforms[0];
            addPlatform.platforms.RemoveAt(0);
            Destroy(urGonnaBeDestryedBuddy);
        }

    }
}
