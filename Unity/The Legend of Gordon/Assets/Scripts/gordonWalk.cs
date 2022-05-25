using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gordonWalk : MonoBehaviour
{
    public float speed = 5;
    float horizontalMove = 0;
    public Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Vertical") * speed;

        myAnim.SetFloat("Speed", horizontalMove);

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -5, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }
}
