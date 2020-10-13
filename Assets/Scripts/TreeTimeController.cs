using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTimeController : ObjectTimeController
{
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<SpriteRenderer>().sprite = sprites[objectTimeState];
    }

    // Update is called once per fram
    void Update()
    {
        
    }

    public override void UpdateState(int update)
    {
        if(update == -1){
            objectTimeState -= 1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //this.GetComponent<SpriteRenderer>().sprite = sprites[objectTimeState];
        } else {
            objectTimeState += 1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //this.GetComponent<SpriteRenderer>().sprite = sprites[objectTimeState];
        }

        if (objectTimeState == 2){
             GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        } else {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
