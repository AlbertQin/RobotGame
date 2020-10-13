using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public int timeState;
    // Start is called before the first frame update
    public GameObject[] observers;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("J")){
            if (timeState != 0){
                timeState -= 1;
                this.transform.position = new Vector2(transform.position.x - 120, transform.position.y);
                foreach (GameObject observer in observers){
                    ObjectTimeController other = (ObjectTimeController) observer.GetComponent<ObjectTimeController>();
                    other.UpdateState(-1);
                }
            }       
        } else if(Input.GetButtonDown("K")){
            if (timeState != 2){
                timeState += 1;
                this.transform.position = new Vector2(transform.position.x + 120, transform.position.y);
                foreach (GameObject observer in observers){
                    ObjectTimeController other = (ObjectTimeController) observer.GetComponent<ObjectTimeController>();
                    other.UpdateState(1);
                }
            }
        }
    }
}
