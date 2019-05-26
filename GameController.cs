using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text questionText;
    public SimpleObjectPool answerButtonObjectPool;
    public Transform answerButtonParent;

    private DataController dataController;
    private RoundData currentRoundData;
    private QuestionData[] questionPool;

    private bool isRoundActive;
    private float timeRemaining;
    private int questionIndex;
    private int playerScore;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();
	
	void Start()
    {// Use this for initialization
        dataController = FindObjectOfType<DataController> ();
        currentRoundData = dataController.GetCurrentRoundData();
        questionPool = currentRoundData.question;
        timeRemaining = currentRoundData.timeLimitInSeconds;

        playerScore = 0;
        questionIndex = 0;

        ShowQuestion();
        isRoundActive = true;
	}
	
    private void ShowQuestion()
    {
        RemoveAnswerButtons();
        QuestionData questionData = questionPool[questionIndex];
        questionText.text = questionData.questionText;

        for(int i = 0; i < questionData.answers.Length; i++)
        {
            print(questionData.answers[i].answerText);
            GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
            answerButtonGameObject.transform.SetParent(answerButtonParent);
            answerButtonGameObjects.Add(answerButtonGameObject);
            print(answerButtonGameObjects.Count);
            AnswerButton answerButton = answerButtonGameObject.GetComponent<AnswerButton>();
            print(answerButton);
            answerButton.answerText.text = questionData.answers[i].answerText;
            //"answerButton", "questionData", "answers[i]". One of these does not exist
        }
        
    }

	private void RemoveAnswerButtons()
    {
        while (answerButtonGameObjects.Count > 0)
        {
            answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
            answerButtonGameObjects.RemoveAt(0);
        }
    }

    public void AnswerButtonClicked(bool isCorrect)
    {

    }

	void Update()
    {// Update is called once per frame
		
	}
}
