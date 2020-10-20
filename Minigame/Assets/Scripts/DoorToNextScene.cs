using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorToNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player") 
            && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D"){
            Camera mainCamera;
            GameObject gameObject = GameObject.Find("Main Camera");
            mainCamera = gameObject.GetComponent<Camera>();
            //mainCamera.transform.Rotate(0, 0, 180.0f);

            PlayerController.IsReverse = true;
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); 
        }
    }
}
