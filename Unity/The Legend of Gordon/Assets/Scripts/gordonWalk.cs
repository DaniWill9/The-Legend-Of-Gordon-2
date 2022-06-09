using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gordonWalk : MonoBehaviour
{
    public float speed = 5;
    float horizontalMove = 0;
    public Animator myAnim;
    public int Attack = 0;
    public int Health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Vertical") * speed;

        myAnim.SetFloat("Speed", horizontalMove);

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -10, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(10 , 0, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
        if(Input.GetKeyUp(KeyCode.Q))
        {
            StartCoroutine(AttackActionQ());

        }
        if(Input.GetKeyUp(KeyCode.Z))
        {
            StartCoroutine(AttackActionZ());
        }
        if (Attack == 1)
        {
            
        }
        if (Attack == 2)
        {

        }
    }
    IEnumerator AttackActionQ()
    {
       // Attack = 1;
        yield return new WaitForSeconds(0.2F);
       // Attack = 0;
    }
    IEnumerator AttackActionZ()
    {
       Attack = 2;
        myAnim.SetTrigger("Attack1");
        yield return new WaitForSeconds(0.2F);
        Attack = 0;
    }
   
}
