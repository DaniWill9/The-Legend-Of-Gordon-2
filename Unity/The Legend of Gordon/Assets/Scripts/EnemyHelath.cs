using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelath : MonoBehaviour
{
    public GameObject enemyM;
    public int Health = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Health;
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; 
        if (Health <= 0)
        {
            StartCoroutine(DeadEnemy());
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator DeadEnemy()
    {
        Health = 100;
        enemyM.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1F);
        enemyM.GetComponent<Transform>().position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-8.0f, 8.0f), Random.Range(-8.0f, 8.0f));
        enemyM.GetComponent<Renderer>().enabled = true;
    }
}
