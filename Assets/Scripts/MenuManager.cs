using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    [SerializeField] private Canvas mainCanvas;
    [SerializeField] private Canvas settingsCanvas;
    [SerializeField] private Canvas creditsCanvas;
    
    private void Start() {
        
    }

    public void StartGame() {
        SceneManager.LoadScene("MainScene");
    }

    public void Exit() {
        
    }

    public void Settings() {
        
    }

    public void Credits() {
        
    }
}
