using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShipScript : MonoBehaviour
{
    public Rigidbody2D RigidBody;
    public Transform Sprite = null; // Declaring AimSprite
    public float vel = 3;
    public Vector3 rotationaxis;

    // Start is called before the first frame update
    void Start()
    {
        Sprite = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.A))
        {
          //Sprite.Rotate(rotationaxis, rvelocity );
          Sprite.Rotate(0,0,22);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
          //Sprite.Rotate(rotationaxis, -rvelocity );
          Sprite.Rotate(0,0,-22);
        }
        
        RigidBody.velocity = Sprite.up * vel * 3;
        
    }
}