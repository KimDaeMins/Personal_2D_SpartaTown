using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager
{
    public string UserName { get; set; } = "dasd";
    public  Sprite UserSprite { get; set; }
    public RuntimeAnimatorController UserAnimator { get; set; }


    public void Init()
    {
        UserName = "";
        UserAnimator = Managers.Resource.LoadAnimatorController("PlayerAnim");
        UserSprite = Managers.Resource.LoadSprite("elf");
    }

    public void UserReAnim()
    {
        GameObject go = GameObject.Find("Player");
        go.GetComponent<PlayerInputController>().CharacterSetting();
    }

    public void UserReName()
    {
        GameObject go = GameObject.Find("Player");
        go.GetComponent<PlayerInputController>().NameSetting();
    }

}
