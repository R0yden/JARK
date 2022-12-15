using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachedChest : MonoBehaviour
{
    private string sceneName;
    private string nextSceneName;
    private int nextSceneNumber;
    public AudioSource reachedChestSound;

    void Start(){
        sceneName = SceneManager.GetActiveScene().name; 
        nextSceneNumber = (sceneName[sceneName.Length - 1] + 1) - '0';
        nextSceneName = "Level " + nextSceneNumber.ToString();
        //ALL CORRECT
        
    }

    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            reachedChestSound.Play();
            SceneManager.LoadScene(nextSceneName);
            PlayerPrefs.SetInt("LevelPassed", nextSceneNumber - 1);
        }
    }
}
