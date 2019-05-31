using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DeckPrefab : MonoBehaviour
{

    [FormerlySerializedAs("CardPrefab")] public GameObject cardPrefab;


     void AssignRankSuit(String cardName, Card card)
    {
        string[] words = cardName.Split('_');

        foreach (var word in words)
        {
            Debug.Log($"<{word}>");

            if (word.Equals("club"))
            {
                card.CardSuit = Card.Suit.Club;
            }

            
        }

    }
    
    void Start()
    {
        Sprite[] cardSprites = Resources.LoadAll<Sprite>("Sprites/fullCardDeck");
        for (int i = 0; i < 1; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i );
            Debug.Log(i);

            AssignRankSuit(cardSprites[i].name, cardInstance.GetComponent<Card>());
            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(50, 550, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
            
            
        }
        
        for (int i = 1; i < 3; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(175f, 580 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 3; i < 6; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(325f, 640 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 6; i < 10; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(475f, 730 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 10; i < 15; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(600f, 850 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 15; i < 22; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(715f, 1000 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 22; i < 29; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(825f, 1210 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 29; i < 52; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(50, 100, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
