using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class URLChecker : MonoBehaviour {
    public InputField mainInputField;
    public RotationGetter linkedURL;
	// Use this for initialization
	void Start () {
        mainInputField.ActivateInputField();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        mainInputField.onEndEdit = se;
	}

    private void SubmitName(string arg0)
    {
            //Debug.Log("URLInput is currently: " + arg0);
            linkedURL.SetURLInput(arg0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
