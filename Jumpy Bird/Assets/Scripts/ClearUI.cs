using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearUI : MonoBehaviour
{
    //[SerializeField] private GameObject _pauseMenu;

    void Awake(){
        gameObject.SetActive(false);
    }
}
