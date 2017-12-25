using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class ButtOnClick : MonoBehaviour {
    public string XmlPath;
    public string Chapter_name;
    public string part;
    public GameObject text;
    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            this.OnClick(this.gameObject);
        });
	}

    private void OnClick(object btnObj)
    {
        XMLController xMLController = new XMLController();
        xMLController.LoadXmlPart(XmlPath, Chapter_name, part, text);
    }
}
