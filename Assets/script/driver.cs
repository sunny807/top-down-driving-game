using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class driver : MonoBehaviour
{
     [SerializeField]float steerSpeed = 1;
     [SerializeField]float moveSpeed = 20f;
    [SerializeField] float speedup = 50f;
    [SerializeField] float speeddown = 15f;
    void Start()
    {
        
    }


    void Update()
    {
      
        float steeramount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steeramount);
        transform.Translate(0,moveamount, 0);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost")
        {
            moveSpeed = speedup;
        } 
    }
     void OnCollisionEnter2D(Collision2D other)
    {
 
        {
            moveSpeed= speeddown;
        }
    }
}
