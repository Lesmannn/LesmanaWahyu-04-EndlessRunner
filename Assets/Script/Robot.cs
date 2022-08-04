using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
	public GameObject End, poin, pause, skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "ground")
		{
			GameObject.Find ("hit-pipe").GetComponent<AudioSource> ().Play ();
			End.SetActive (true);
			poin.SetActive (false);
			pause.SetActive (false);
			if (PlayerPrefs.GetInt ("Highscore") < skor.GetComponent<Score> ().score)
			{
				PlayerPrefs.SetInt ("Highscore", skor.GetComponent<Score> ().score);
			}
			Time.timeScale=0;
		}
		if (other.gameObject.name == "Score")
		{
			GameObject.Find ("suara score").GetComponent<AudioSource> ().Play ();
			skor.GetComponent<Score> ().score++;
		}
	}
}
