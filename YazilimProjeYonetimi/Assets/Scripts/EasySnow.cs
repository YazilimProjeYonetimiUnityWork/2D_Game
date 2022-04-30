using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasySnow : MonoBehaviour
{
    private SpriteRenderer spr;
    private bool isSnowing = false;
    private GameObject player;
    private GameObject baby;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.enabled = false;
        player = GameObject.FindGameObjectWithTag("Player");
        baby = GameObject.FindGameObjectWithTag("Baby");
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
        player.GetComponent<PlayerWalk>().TakeDamage(5);
        baby.GetComponent<PlayerWalk>().TakeDamage(10);
        StartCoroutine(disableSnow());
    }

    IEnumerator disableSnow()
    {
        yield return new WaitForSeconds(5f);
        spr.enabled = false;
        isSnowing = false;
    }
}
