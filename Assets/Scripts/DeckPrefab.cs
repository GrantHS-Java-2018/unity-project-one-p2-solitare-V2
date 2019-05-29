using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DeckPrefab : MonoBehaviour
{

    [FormerlySerializedAs("CardPrefab")] public GameObject cardPrefab;
    Sprite[] cardSprites = Resources.LoadAll<Sprite>("Sprites/fullCardDeck");
    void Start()
    {
        for (int i = 0; i < 52; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<SpriteRenderer>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(2 * i - 8, 0f, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
