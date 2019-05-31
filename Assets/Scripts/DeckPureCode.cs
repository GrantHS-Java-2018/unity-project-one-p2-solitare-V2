using System.Collections;
using UnityEngine.EventSystems;

using UnityEngine;
using UnityEngine.UI;

public class DeckPureCode : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Stack cardStack = new Stack();
    void Start()
    {
        Sprite[] cardSprites = Resources.LoadAll<Sprite>("Sprites/fullCardDeck");
        
        for (int i = 0; i < 52; i++)
        {         
           
            GameObject cardInstance = new GameObject("Card" + i);

           
            
            cardInstance.transform.parent = this.transform;


            CanvasRenderer canvasRenderer = cardInstance.AddComponent<CanvasRenderer>();
            Image spriteRenderer = cardInstance.AddComponent<Image>();
            RectTransform rectTransform = cardInstance.AddComponent<RectTransform>();
            

            spriteRenderer.sprite = cardSprites[i];
            

            float myScale = 1f;
            spriteRenderer.transform.localScale = new Vector3(myScale, myScale, myScale);


            rectTransform.transform.position = new Vector3( -101f, 100f, 42.125f);
            rectTransform.transform.localScale = new Vector3(myScale, myScale, myScale);
            
     
            Debug.Log("Created Card Instance " + i);
            cardStack.Push(cardInstance);
                //2f * i - 10
                
        }
        
        
    }
    
    //Draggables code
    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData){
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;
    }
    
    public void OnEndDrag(PointerEventData eventData){
        
        Debug.Log("OnEndDrag");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}