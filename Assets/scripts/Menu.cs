using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;

    private Button startBtn;
    private Button quitBtn;
    private Button settingBtn;
    // Start is called before the first frame update
    private void OnEnable()
    {
        VisualElement panel = _uiDocument.rootVisualElement.Q("MainMenu");
        if (panel != null)
        {
             startBtn = panel.Q<Button>("start") as Button;
             quitBtn = panel.Q<Button>("quit") as Button;
             settingBtn = panel.Q<Button>("settings") as Button;
             startBtn?.RegisterCallback<ClickEvent>(LoadGame);
             quitBtn?.RegisterCallback<ClickEvent>(QuitGame);
             settingBtn?.RegisterCallback<ClickEvent>(LoadSettings);
        }
    }
    
    private void OnDisable()
    {
        startBtn?.UnregisterCallback<ClickEvent>(LoadGame); 
        quitBtn?.UnregisterCallback<ClickEvent>(QuitGame);
        settingBtn?.UnregisterCallback<ClickEvent>(LoadSettings);
    }

    private void LoadGame(ClickEvent evt)
    {
        SceneManager.LoadScene("lobby");
    }
    private void QuitGame(ClickEvent evt)
    {
        Debug.Log("fermer");
        Application.Quit();
    }
    private void LoadSettings(ClickEvent evt)
    {
        Debug.Log("settings");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
