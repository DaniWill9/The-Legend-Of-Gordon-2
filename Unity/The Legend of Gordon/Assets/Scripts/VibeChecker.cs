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
            enemy.GetComponent<EnemyHelath>().Health = enemy.GetComponent<EnemyHelath>().Health - 1;

        }
        else if (Characters[0].GetComponent<gordonWalk>().Attack == 2)
        {
            enemy.GetComponent<EnemyHelath>().Health = enemy.GetComponent<EnemyHelath>().Health - 2;
        }
        else if (Characters[1].GetComponent<gordonWalk>().Attack == 1)
        {

        }
        else if (Characters[1].GetComponent<gordonWalk>().Attack == 2)
        {

        }
        if (enemy.GetComponent<EnemyHelath>().Health <= 0)
        {
            StartCoroutine(DeadEnemy());
            enemy.GetComponent<EnemyHelath>().Health = 100;
        }
        IEnumerator DeadEnemy()
        {
            enemy.GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(1F);
            enemy.GetComponent<Transform>().position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            enemy.GetComponent<Renderer>().enabled = true;
        }
    }
}
   
