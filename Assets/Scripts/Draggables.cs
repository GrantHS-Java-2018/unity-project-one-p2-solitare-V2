using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggables : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        transform.GetSiblingIndex();
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        DeckPrefab deck = new DeckPrefab();
        deck.cardPrefab.GetComponent<Card>();


        /*   if(Card.rank==TopCard.rank+1 && 	suit==matching ){
              AllowDrop = true;
           }     
           else{
           AllowDrop = false;
           }
       }*/
    }
}



