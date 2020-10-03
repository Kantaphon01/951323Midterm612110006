using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectMenuScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _Stage1Button;
    [SerializeField] Button _Stage2Button;
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
        _Stage1Button.onClick.AddListener(delegate { Stage1ButtonClick(_Stage1Button); });
         _Stage2Button.onClick.AddListener(delegate { Stage2ButtonClick(_Stage2Button); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenuButtonClick(Button button)
    {
         SceneManager.UnloadSceneAsync("SceneStageSelect");
         SceneManager.LoadScene("SceneMainMenu");
         }
    public void Stage1ButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneStage1");
    }
    public void Stage2ButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneStage2");
    }
}
