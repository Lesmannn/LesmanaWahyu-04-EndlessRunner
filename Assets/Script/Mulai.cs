using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mulai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
	public void LoadScene() 
		{
			SceneManager.LoadScene("inGame");
			Time.timeScale = 1;
		}

    // Update is called once per frame
    void Update()
    {
        
    }
}
