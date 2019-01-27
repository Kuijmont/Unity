using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementoInteractivo : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	public bool pulsed;

	public void OnPointerDown(PointerEventData eventData){
        pulsed = true;

	}

	public void OnPointerUp(PointerEventData eventData){
        pulsed = false;
	}
}
