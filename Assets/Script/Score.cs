using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		GetComponent<Text> ().text = score.ToString();
    }
	public void OnShowAddButton()
	{
		score += 5;
		AddManager.instance.PlayAdd();
		Time.timeScale = 0f;
	}
}
