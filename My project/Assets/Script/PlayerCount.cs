using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCount : MonoBehaviour
{
    private TMP_Text _text;

    public void OpenUserUI()
    {
        GameObject go = GameObject.Find("UIs").transform.GetChild(2).gameObject;
        if(go.activeSelf)
            go.SetActive(false);
        else
            go.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        _text = transform.GetChild(0).GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Âü¿©ÀÚ : " + GameObject.Find("User").transform.childCount;
    }
}
