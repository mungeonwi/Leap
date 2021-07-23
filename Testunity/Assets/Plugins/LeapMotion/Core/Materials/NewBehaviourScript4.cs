using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript4 : MonoBehaviour
{
    [SerializeField] Text time1, time2;
    // Update is called once per frame
    void Update()
    {
        time1.text = DateTime.Now.ToString("tth : mm : ss");
        time2.text = DateTime.Now.ToString("yy : MM  : dd");
    }
}
