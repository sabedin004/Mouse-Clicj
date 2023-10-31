using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    //variable for the game
    float startPosX;        //start position on the x-axis
    float startPosY;        //start position on the y-axis
    bool isBeingHeld;       //determine if object is being held




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld)                //if object is being held
        {
            Vector2 mousePos;                            //create a vector two called mousePos
            mousePos = Input.mousePosition;                                                    // change the value of mousePos
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);                              // change the value of mousePos
            gameObject.transform.localPosition = new Vector2(mousePos.x, mousePos.y);        // change position of 
        }
    }

    void OnMouseDown()              //when you press the mouse button
    {
        if (Input.GetMouseButtonDown(0))                                                    //is the left mouse button is clicked
        {
            Vector2 mousePos;                                                                //create a vector two called mousePos
            mousePos = Input.mousePosition;                                                 //change the value of mousePos
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);                           //change the value of mousePos

            isBeingHeld = true;                                                           //object is being help
        }   
    }

    void OnMouseUp()                                                                      //when you let go of the mouse button
    {                                               
        isBeingHeld = false;                                                            // object is no longer being held
    }


}
