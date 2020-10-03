using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    

public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _stageselectButton;
    [SerializeField] Button _creditButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;

    void Start()
    {
        
            _optionsButton.onClick.AddListener (
                delegate{OptionsButtonClick(_optionsButton);});
                _exitButton.onClick.AddListener (
            delegate{ExitButtonClick(_exitButton);});
            _creditButton.onClick.AddListener(
            delegate { CreditButtonClick(_creditButton); });
        _stageselectButton.onClick.AddListener(
            delegate { StageSelectButtonClick(_stageselectButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OptionsButtonClick(Button button) { 
       if(!GameApplicationManager.Instance.IsOptionMenuActive)
       {
           SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
           GameApplicationManager.Instance.IsOptionMenuActive =true;

       }
   }
    public void CreditButtonClick(Button button)
    {
            SceneManager.LoadScene("SceneCredit");
    }
    public void StageSelectButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneStageSelect", LoadSceneMode.Additive);
    }

    public void ExitButtonClick(Button button) {
       Application.Quit();
   }
}
