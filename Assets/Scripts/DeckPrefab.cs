using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = System.Random;

public class DeckPrefab : MonoBehaviour
{

    [FormerlySerializedAs("CardPrefab")] public GameObject cardPrefab;


     void AssignRankSuit(String cardName, Card card)
    {
        string[] words = cardName.Split('_');

        foreach (var word in words)
        {
            Debug.Log($"<{word}>");

            switch (word)
            {
                case "clubs":
                    card.CardSuit = Card.Suit.Club;
                    break;
                case "spades":
                    card.CardSuit = Card.Suit.Spade;
                    break;
                case "hearts":
                    card.CardSuit = Card.Suit.Heart;
                    break;
                case "diamonds":
                    card.CardSuit = Card.Suit.Diamond;
                    break;
                default:
                    Debug.Log("Not a suit");
                    break;
            }
          
        }
        
        foreach (var word in words)
        {
            Debug.Log($"<{word}>");

            switch (word)
            {
                case "ace":
                    card.CardRank = Card.Rank.Ace;
                    break;
                case "two":
                    card.CardRank = Card.Rank.Two;
                    break;
                case "three":
                    card.CardRank = Card.Rank.Three;
                    break;
                case "four":
                    card.CardRank = Card.Rank.Four;
                    break;
                case "five":
                    card.CardRank = Card.Rank.Five;
                    break;
                case "six":
                    card.CardRank = Card.Rank.Six;
                    break;
                case "seven":
                    card.CardRank = Card.Rank.Seven;
                    break;
                case "eight":
                    card.CardRank = Card.Rank.Eight;
                    break;
                case "nine":
                    card.CardRank = Card.Rank.Nine;
                    break;
                case "ten":
                    card.CardRank = Card.Rank.Ten;
                    break;
                case "jack":
                    card.CardRank = Card.Rank.Jack;
                    break;
                case "queen":
                    card.CardRank = Card.Rank.Queen;
                    break;
                case "king":
                    card.CardRank = Card.Rank.King;
                    break;
                default:
                    Debug.Log("Not a rank");
                    break;	
            }
          
        }

    }
     
     
     
    
    void Start()
    {
        
        Sprite[] cardSprites = Resources.LoadAll<Sprite>("Sprites/fullCardDeck");
        cardSprites = ArrayExtensions.Shuffle(cardSprites);
        
      
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
        
        for (int i = 15; i < 21; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(715f, 1000 - 30*i, 0f);
            Debug.Log("Created Instance " + i);
            cardInstance.transform.localScale -= new Vector3(.5F, .5F, 0);
        }
        
        for (int i = 21; i < 28; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            cardInstance.name = ("Card" + i);
            Debug.Log(i);
         

            
            cardInstance.GetComponent<Image>().sprite = cardSprites[i];
            cardInstance.transform.position = new Vector3(825f, 1180 - 30*i, 0f);
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

public static class ArrayExtensions
{
    private static Random random = new Random();

    public static T[] Shuffle<T>(this T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            int r = i + random.Next(n - i);
            T t = array[r];
            array[r] = array[i];
            array[i] = t;
        }
        return array;
    }
}