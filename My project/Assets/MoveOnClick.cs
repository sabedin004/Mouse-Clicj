using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{

    //variable for the game
    public float speed = 10f;       //control the speed of movement 

    Vector2 lastMousePos;          // stire the position of the mouse


    bool moving;                   // keep track of movement 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))        // if left button is clicked
        {
            lastMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);          // change the value of LastMousepos
            moving = true;                      //change moving to true/oject is moving
        }

        if (moving && (Vector2)transform.position != lastMousePos)
        {
            float step = speed * Time.deltaTime;                                //create a variablr for the movement 
            transform.position = Vector2.MoveTowards(transform.position, lastMousePos, step);
        }


        else
        {
            moving = false;
        }


    }
}
