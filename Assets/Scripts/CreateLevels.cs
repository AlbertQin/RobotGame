using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreateLevels : MonoBehaviour
{
    public UnityEngine.UI.Button prebutton;
    // Start is called before the first frame update
    void Start()
    {
        int offset = -140;
        for (int i = 0; i <= 6; i++){
            UnityEngine.UI.Button buttonObject = Instantiate(prebutton);
            buttonObject.transform.position = new Vector2(this.transform.position.x + offset + i * 40, this.transform.position.y);
            int x = new int();
            x = i;
            buttonObject.GetComponentInChildren<UnityEngine.UI.Text>().text = x.ToString();
            ((UnityEngine.UI.Button) buttonObject).onClick.AddListener(delegate { LoadLevel(x); });
            buttonObject.transform.parent = this.transform;
        }
    }

    void LoadLevel(int i){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 + i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
