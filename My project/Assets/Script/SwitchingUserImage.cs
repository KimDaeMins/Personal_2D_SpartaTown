using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchingUserImage : MonoBehaviour
{
    public Sprite _sprite;
    public RuntimeAnimatorController _animatorController;
    public void ChangeUserData()
    {
        Managers.Data.UserSprite = _sprite;
        Managers.Data.UserAnimator = _animatorController;
        GameObject go = GameObject.Find("Canvas");
        go.transform.GetChild(1).gameObject.SetActive(true);
        go.transform.GetChild(2).gameObject.SetActive(true);
        go.transform.GetChild(3).gameObject.SetActive(true);

        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false);
    }

    public void ChangeUserDataInGame()
    {
        Managers.Data.UserSprite = _sprite;
        Managers.Data.UserAnimator = _animatorController;
        GameObject go = GameObject.Find("Canvas");
        Managers.Data.UserReAnim();
        GameObject.Find("UIs").transform.GetChild(0).gameObject.SetActive(false);
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
