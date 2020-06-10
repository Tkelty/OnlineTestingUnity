using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DownloadTester : MonoBehaviour
{
    string info = "Here is some text and test info._-!";
    public InputField field;
    public string jsonSample = "Just Testing simple stuff for now";

    // Start is called before the first frame update
    void Start()
    {
        CopyToClipboard();
    }

    public void CopyInputFieldText()
    {
        TextEditor text = new TextEditor();
        Debug.Log(field.text);
        text.text = field.text;
        text.SelectAll();
        text.Copy();
    }



    public void CopyToClipboard()
    {
        TextEditor text = new TextEditor();
        text.text = info;
        text.SelectAll();
        text.Copy();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
