using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    private SpriteRenderer spr;
    private bool isSnowing = false;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.enabled = false;
        
    }

    
    void Update()
    {
        Snowing();
    }

    void Snowing()
    {
        if (!isSnowing)
        {
            StartCoroutine(snowFall());
            isSnowing = true;
        }
    }

    IEnumerator snowFall()
    {
        yield return new WaitForSeconds(Random.Range(10f, 30f));
        spr.enabled = true;
        StartCoroutine(disableSnow());
    }

    IEnumerator disableSnow()
    {
        yield return new WaitForSeconds(5f);
        spr.enabled = false;
        isSnowing = false;
    }
}
