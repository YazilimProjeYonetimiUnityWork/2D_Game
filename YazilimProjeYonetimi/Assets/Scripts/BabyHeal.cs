using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyHeal : MonoBehaviour
{
    public GameObject baby;
    void Start()
    {
        baby = GameObject.FindGameObjectWithTag("Baby");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            healBaby();
        }
    }
    void healBaby()
    {
        baby.GetComponent<PlayerWalk>().Heal(25);
    }
}
