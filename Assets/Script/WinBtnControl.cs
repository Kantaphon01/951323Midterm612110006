using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinBtnControl : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _nextStageButton;
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
        _nextStageButton.onClick.AddListener(delegate { NextStageButtonClick(_nextStageButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenuButtonClick(Button button)
    {
         SceneManager.UnloadSceneAsync("SceneWin");
         SceneManager.LoadScene("SceneMainMenu");
         }
         public void NextStageButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneWin");
        SceneManager.LoadScene("SceneStage2");
    }
}
