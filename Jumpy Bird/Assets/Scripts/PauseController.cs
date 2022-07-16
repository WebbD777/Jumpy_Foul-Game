using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    public void PauseGame(){
        Time.timeScale = 0f;
        _pauseMenu.SetActive(true);
    }

    public void ResumeGame(){
        Time.timeScale = 1f;
         _pauseMenu.SetActive(false);
    }

    public void Menu(){
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;

    }


     void Update()
    {
        if (Input.GetButtonDown("Cancel")){
            Time.timeScale = 0f;
            _pauseMenu.SetActive(true);
        }
        
    }


}
