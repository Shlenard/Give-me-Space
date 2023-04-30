using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShipScript : MonoBehaviour
{   
    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {   
      
        int x=0;
        if (Input.GetKeyDown(KeyCode.W)==true)
        {   
            x=x+10;
            transform.Rotate(new Vector3(0, 0, x));
        }
        if (Input.GetKeyDown(KeyCode.S)==true)
        {
            x=x-10;
            transform.Rotate(new Vector3(0, 0, x));
        }
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {   
            myRigidbody.velocity = Vector2.up * 10;
        }
        
    }
}
