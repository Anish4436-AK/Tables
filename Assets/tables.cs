using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class tables : MonoBehaviour
{
    public TextMeshProUGUI tab;
    public TMP_InputField Value;

    int num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // math();
    }
    public void math()
    {
        num=Convert.ToInt32(Value.text);
        string result="";
        for(int i=1;i<=10;i++)
        {
            result += $"{num} x {i}={num*i}\n";
        }
        tab.text = result;


    }
}
