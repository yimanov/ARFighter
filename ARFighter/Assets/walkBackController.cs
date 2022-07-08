using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class walkBackController : MonoBehaviour
{

    public void OnPointerDown(PointerEventData data)
	{

		fightController.mvBack = true;
	}

    public void OnPointerUp(PointerEventData data)
	{
		fightController.mvBack = false;
	}


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
