using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _countdownText;
    float _CurrentTime = 0f;
    [SerializeField] float _startingTime =40f;
    
    void Start()
    {
        _CurrentTime =_startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        _CurrentTime -= 1*Time.deltaTime;
        _countdownText.text =_CurrentTime.ToString("0");
        if(_CurrentTime <=0)
        {
            _CurrentTime =0; 
            SceneManager.LoadSceneAsync("SceneLose");
        }
        
    }
 
}
