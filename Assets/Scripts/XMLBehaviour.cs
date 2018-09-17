using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XMLBehaviour : MonoBehaviour {
    [SerializeField] Toggle wiggleandnothingToggle;
    [SerializeField] Toggle robotdoesnothingToggle;
    [SerializeField] Toggle baselineToggle;
    [SerializeField] Toggle baselinefailToggle;
    [SerializeField] Toggle switchToggle;
    [SerializeField] Toggle switchfailToggle;
    [SerializeField] Toggle scaleToggle;
    [SerializeField] Toggle scalefailToggle;
    [SerializeField] Toggle multipleonswitchToggle;
    [SerializeField] Toggle twoonscaleToggle;
    //There is currently one checkboxe that does not serve a purpose, add it here once done.
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WiggleandnothingUpdate()
    {
        if (wiggleandnothingToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void RobotdoesnothingUpdate()
    {
        if (robotdoesnothingToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void BaselineUpdate()
    {
        if (baselineToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void BaselinefailUpdate()
    {
        if (baselinefailToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void SwitchUpdate()
    {
        if (switchToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void SwitchfailUpdate()
    {
        if (switchfailToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void ScaleUpdate()
    {
        if (scaleToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void ScalefailUpdate()
    {
        if (scalefailToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void MultipleonswitchUpdate()
    {
        if (multipleonswitchToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    public void TwoonscaleUpdate()
    {
        if (twoonscaleToggle.isOn)
        {
            print("On!");
        }
        else
        {
            print("Off!");
        }
    }
    //The same applies down here, make a new void for the new update.
}
