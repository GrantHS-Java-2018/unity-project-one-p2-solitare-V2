using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DeckPrefab : MonoBehaviour
{

    [FormerlySerializedAs("CardPrefab")] public GameObject cardPrefab;
   
    void Start()
    {
        Sprite[] cardSprites = Resources.LoadAll<Sprite>("Sprites/fullCardDeck");
        for (int i = 0; i < 1; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(100, 500, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 1; i < 3; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(250f, 530 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 3; i < 6; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(400f, 590 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 6; i < 10; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(550f, 680 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 10; i < 16; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(700f, 800 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 16; i < 23; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(19 * i + 2, 200f, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
