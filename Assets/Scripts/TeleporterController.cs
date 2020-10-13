using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterController : MonoBehaviour
{
    public int type;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COLLIDED");
        if (type == -1){
            if(collision.gameObject.GetComponent<ObjectTimeController>()){
                collision.gameObject.transform.position = new Vector2(transform.position.x - 120, transform.position.y);
                collision.gameObject.GetComponent<ObjectTimeController>().UpdateState(1);
            }
        } else {
            if(collision.gameObject.GetComponent<ObjectTimeController>()){
                collision.gameObject.transform.position = new Vector2(transform.position.x + 120, transform.position.y);
                collision.gameObject.GetComponent<ObjectTimeController>().UpdateState(-1);
            }
        }

    }
}
