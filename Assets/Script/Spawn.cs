using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject Tower;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	void spawn()
	{
		Instantiate (Tower, transform.position, transform.rotation);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
