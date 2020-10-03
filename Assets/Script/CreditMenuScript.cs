using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditMenuScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenuButtonClick(Button button)
    {
         SceneManager.UnloadSceneAsync("SceneCredit");
         SceneManager.LoadScene("SceneMainMenu");
         }
}
