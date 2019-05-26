using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnswerButton : MonoBehaviour {
    public Text answerText;
    private AnswerData answerData;

	
	void Start ()
    {// Use this for initialization
		
	}
	
    public void Setup(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }
	
	void Update ()
    {// Update is called once per frame
		
	}
}
