using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathBoxController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.GetComponent<CharacterController>()){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
