using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{   
    public Rigidbody2D cam;
    // Start is called before the first frame update
    void Start()
    {
        cam.velocity = Vector2.right * 8;
    }

    // Update is called once per frame
    void Update()
    {

            
    }
}
