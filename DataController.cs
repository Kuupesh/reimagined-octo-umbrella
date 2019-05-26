using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    public RoundData[] allRoundData;
	
	void Start ()
    {// Use this for initialization
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("Menu");
	}
	
    public RoundData GetCurrentRoundData(int round = 0)
    {
        return allRoundData[round];
    }
	
	void Update ()
    {// Update is called once per frame
		
	}
}
