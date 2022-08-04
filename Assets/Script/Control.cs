using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
	public float berat;
	public float loncat;
	public GameObject Robot, Instruksi, Spawn, pause;
	public GameObject poin;
    // Start is called before the first frame update
    void Start()
    {
		
    }
	void OnMouseDown()
	{
		if (Time.timeScale == 1) {
			GameObject.Find ("flap").GetComponent<AudioSource> ().Play ();
			Spawn.SetActive(true);
			Instruksi.SetActive(false);
			poin.SetActive(true);
			pause.SetActive(true);
			Robot.GetComponent<Rigidbody2D> ().gravityScale = berat;
			Robot.GetComponent<Rigidbody2D> ().velocity = new Vector2 (Robot.GetComponent<Rigidbody2D>  ().velocity.x, loncat);
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit();
		}
    }
}
