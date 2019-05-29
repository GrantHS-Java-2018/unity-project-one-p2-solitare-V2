﻿using System;
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
            cardInstance.transform.position = new Vector3(50, 500, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 1; i < 3; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(175f, 530 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 3; i < 6; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(325f, 590 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 6; i < 10; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(475f, 680 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 10; i < 15; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(600f, 800 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 15; i < 22; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(715f, 950 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 22; i < 29; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(825f, 1160 - 30*i, 0f);
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
