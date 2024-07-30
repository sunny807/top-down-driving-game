using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{
    bool haspackage;
    [SerializeField] Color32 haspackagecolor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 nopackagecolor = new Color32(1, 1, 1, 1);
    [SerializeField] float time = 0.1f;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ouch!!!!");
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package"&& !haspackage)
        {
            Debug.Log("package reviced...");
            haspackage = true;
            spriteRenderer.color = haspackagecolor;
            Destroy( other.gameObject,time);
           
        }

        if (other.tag == "customer" && haspackage) 
        
        {
            Debug.Log("deliveried!");
            haspackage= false;
            spriteRenderer.color = nopackagecolor;
        }
    }

}
