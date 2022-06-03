using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibeChecker : MonoBehaviour
{
    public GameObject[] Characters;
    public GameObject enemy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Characters[0].GetComponent<gordonWalk>().Attack == 1)
        {
            enemy.GetComponent<EnemyHelath>().Health = 50;

        }
        else if (Characters[0].GetComponent<gordonWalk>().Attack == 2)
        {
            enemy.GetComponent<EnemyHelath>().Health = 20;
        }
        else if (Characters[1].GetComponent<gordonWalk>().Attack == 1)
        {

        }
        else if (Characters[1].GetComponent<gordonWalk>().Attack == 2)
        {

        }

    }
}
