using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggables : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
     Vector3 startPosition;
     Transform startParent;
     public GameObject canvas;
     private Transform canvasTransform;
     public static GameObject itemBeingDragged;
    
    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("OnBeginDrag");
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        canvasTransform = canvas.transform;
        transform.parent = canvasTransform;
}

    public void OnDrag(PointerEventData eventData){
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;
    }
    
    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("OnEndDrag");
    }



}
