using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeText : MonoBehaviour
{
	public Animator anim;
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space)){
			anim.Play("StartText");
		}
	}
	
	public void turnThisOff()
	{
		gameObject.SetActive(false);
	}
}
