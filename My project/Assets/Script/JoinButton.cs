using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    public TMP_InputField _InputField;

    public void GotoMainScene()
    {
        if(_InputField.text.Length >= 2)
        {
            Managers.Data.UserName = _InputField.text;
            SceneManager.LoadScene("MainScene");
        }
    }

    public void SwitchingUserName()
    {
        if (_InputField.text.Length >= 2)
        {
            Managers.Data.UserName = _InputField.text;
            Managers.Data.UserReName();
            GameObject.Find("UIs").transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
