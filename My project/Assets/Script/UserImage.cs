using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserImage : MonoBehaviour
{
    private Image _myImage;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Util.FindChild(transform.gameObject , "PlayerImage" , true);
        _myImage = go.GetComponent<Image>();
    }

    public void PickSprite()
    {
        GameObject.Find("NameArea").SetActive(false);
        GameObject.Find("Join").SetActive(false);
        transform.gameObject.SetActive(false);
        
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
    }

    public void IngameImageChange()
    {
        GameObject.Find("UIs").transform.GetChild(0).gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
       _myImage.sprite = Managers.Data.UserSprite;
    }
}
