using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggables : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        transform.GetSiblingIndex();  //Bring the dragged card to the front
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;  //track position
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        DeckPrefab deck = new DeckPrefab();
        deck.cardPrefab.GetComponent<Card>();
        var cardPosition = transform.position;


        /*   if(Card.rank==TopCard.rank+1 && 	suit==matching ){
              AllowDrop = true;
           }     
           else{
           AllowDrop = false;
           }
       }*/
    }
}



