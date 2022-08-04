using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
	public GameObject Isicredit, pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	public void back()
	{
		Isicredit.SetActive(false);
		pausemenu.SetActive(true);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
