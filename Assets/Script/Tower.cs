using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
	float Ytower;
	public float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
		Ytower = Random.Range (-3, 3);
    }

    // Update is called once per frame
    void Update()
    {
		if (Time.timeScale == 1) {
			transform.localPosition = new Vector3 (transform.localPosition.x-kecepatan, Ytower, 1f);
		}
    }
}
