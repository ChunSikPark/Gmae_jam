using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        /*
        if (Input.anyKeyDown)
        {
            Debug.Log("Key has pressed"); //when press the key
        }
        if (Input.anyKey)
        {
            Debug.Log("Holding the key"); // when hold the key
        }
        */

        /*
        //When arrow key is pressed
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Debug.Log("Moving Left");
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("Moving Right");
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Debug.Log("Moving forward");
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Debug.Log("Moving backward");
        }
        if (Input.GetMouseButtonDown(0)) //Left click
        {
            Debug.Log("Left click");
        }
        if (Input.GetMouseButtonDown(1)) //Right click
        {
            Debug.Log("Right click");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("holding left click");
        }
        if (Input.GetMouseButtonUp(0)) //
        {
            Debug.Log("No longer holding left click");
        }
        */

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Moving horizontal" + " " + Input.GetAxisRaw("Horizontal"));
            /** GetAxis = move depend on how long user press down the button
             *  GetAxisRow = move maximum distance no matter how long user press down the button
             **/
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("Moving Vertical" + " "
                + Input.GetAxisRaw("Vertical"));
        }
    }
}
