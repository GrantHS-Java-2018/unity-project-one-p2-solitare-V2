using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPureCode : MonoBehaviour
{

    // I added a sprite and split it using the sprite editor
    // Set "Sprite Mode" to Multiple
    // Open Sprite Editor and split using rows/cols
    // More help here https://docs.unity3d.com/Manual/SpriteEditor.html
    // Full deck image came from here: http://www.milefoot.com/math/discrete/counting/images/cards.png
    // Start is called before the first frame update
    Stack cardStack = new Stack();
    void Start()
    {
        //Get the sliced card images as an array of 52 sprites
        Sprite[] cardSprites = Resources.LoadAll<Sprite>("Sprites/fullCardDeck");
        
        for (int i = 0; i < 52; i++)
        {         
           
            GameObject cardInstance = new GameObject("Card" + i);
            
            cardInstance.transform.parent = this.transform;
            

            SpriteRenderer spriteRenderer = cardInstance.AddComponent<SpriteRenderer>();

            spriteRenderer.sprite = cardSprites[i];
            

            float myScale = 4f;
            spriteRenderer.transform.localScale = new Vector3(myScale, myScale, myScale);


            cardInstance.transform.position = new Vector3( .4f * i - 10, 0f, 0f);
            
     
            Debug.Log("Created Instance " + i);
            cardStack.Push(cardInstance);
                
                
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}