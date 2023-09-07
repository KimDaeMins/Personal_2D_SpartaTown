using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{
    public TMP_Text _InputField;

    public void OnClickNameUI()
    {
        GameObject.Find("UIs").transform.GetChild(1).gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Util.FindChild(transform.gameObject , "NameUI" , true);
        _InputField = go.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _InputField.text = Managers.Data.UserName;
    }
}
