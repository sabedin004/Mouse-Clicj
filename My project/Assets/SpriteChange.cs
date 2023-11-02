using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    //variable for the game
    public SpriteRenderer sp;
    public Sprite newSprite;
    public Sprite originalSprite;
    bool Changed = false;


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
            Changed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ChangeSprite();
                Changed = false;
        }
    }
    void ChangeSprite()
    {
        if(!Changed)
        {
             sp.sprite = newSprite;
        }
        else
        {
            sp.sprite = originalSprite;
        }
    }
}
