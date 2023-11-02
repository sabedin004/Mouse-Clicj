using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    //variable for the game
    public SpriteRenderer sp;
    public Sprite newSprite;


    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
        }
    }
    void ChangeSprite()
    {
        sp.sprite = newSprite;
    }
}
