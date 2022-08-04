using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public GameObject pausemenu, Isicredit;

	public void Return()
	{
		pausemenu.SetActive(false);
		Time.timeScale = 1f;
	}
	public void Pause()
	{
		pausemenu.SetActive(true);
		Time.timeScale = 0f;
	}
	public void Home()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
	}
	public void Credit()
	{
		Isicredit.SetActive(true);
		pausemenu.SetActive(false);
		Time.timeScale = 0f;
	}
}
