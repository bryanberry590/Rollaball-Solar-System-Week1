using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartButtonClick : MonoBehaviour
{


    void Update(){
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
