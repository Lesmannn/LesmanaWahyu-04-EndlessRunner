using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAkhir : MonoBehaviour
{
	public GameObject Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (gameObject.name == "Score Akhir")
		{
			GetComponent<Text> ().text = Score.GetComponent<Score> ().score.ToString();
		}
		else if (gameObject.name == "Highscore")
		{
			GetComponent<Text> ().text = PlayerPrefs.GetInt ("Highscore").ToString();
		}
    }
}
