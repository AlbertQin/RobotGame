using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTimeController : MonoBehaviour
{
    public int objectTimeState;
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<SpriteRenderer>().sprite = sprites[objectTimeState];
    }

    // Update is called once per fram
    void Update()
    {
        
    }

    public virtual void UpdateState(int update)
    {

    }
}
