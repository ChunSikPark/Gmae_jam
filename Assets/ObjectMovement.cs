using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * 0.1f;
        float moveY = Input.GetAxis("Vertical") * 0.1f;

        Vector3 vec = new Vector3(moveX, 
            0, moveY); 
        transform.Translate(vec); //Translate add up the vector 

    }
}
