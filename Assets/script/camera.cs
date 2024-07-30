using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    [SerializeField] GameObject thingtofollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = thingtofollow.transform.position + new Vector3 (-11.5f,0.4f,-1);
        
    }
}
