using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserUI : MonoBehaviour
{
    Transform _baseObjectTransform;
    private TMP_Text _text;
    public void ExtButton()
    {
        GameObject.Find("UIs").transform.GetChild(2).gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        _text = transform.GetChild(0).GetComponent<TMP_Text>();
        _baseObjectTransform = GameObject.Find("User").transform;
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "";
        foreach (Transform t in _baseObjectTransform)
        {
            _text.text += t.GetComponent<ObjectBase>().Name;
            _text.text += '\n';
        }
    }
}
