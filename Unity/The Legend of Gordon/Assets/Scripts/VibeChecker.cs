using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibeChecker : MonoBehaviour
{
    public GameObject[] Characters;
    public GameObject enemy;
    public BoxCollider2D DaEnemy;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (enemy.GetComponent<EnemyHelath>().Health <= 0)
        {
            StartCoroutine(DeadEnemy());

        }
        IEnumerator DeadEnemy()
        {
            enemy.GetComponent<EnemyHelath>().Health = 100;
            enemy.GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(1F);
            enemy.GetComponent<Transform>().position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-8.0f, 8.0f), Random.Range(-8.0f, 8.0f));
            enemy.GetComponent<Renderer>().enabled = true;
        }
    }
   
}
   
