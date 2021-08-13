using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoText : MonoBehaviour
{
    public Text testText;
    float delay = 0.1f;
    string text = "";
    int currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        WriteText("Test test... Your mom. lol");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void WriteText(string theText)
    {
        testText.text = "";
        currentPosition = 0;
        text = theText;
        StartCoroutine("Write");
    }

    IEnumerator Write()
    {
        for (int i = 0; i < text.Length; i++)
        {
            testText.text += text[currentPosition++];

            yield return new WaitForSeconds(delay);
        }
    }
}
