using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUtil : MonoBehaviour
{
    private TMP_Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = transform.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = DateTime.Now.ToString(("HH:mm:ss"));
    }
}
