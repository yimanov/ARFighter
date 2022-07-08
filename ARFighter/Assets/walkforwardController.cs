using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class walkforwardController : MonoBehaviour
{

	public void OnPointerDown(PointerEventData data)
	{

		fightController.mvFWD = true;
	}

	public void OnPointerUp(PointerEventData data)
	{
		fightController.mvFWD = false;
	}


	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
