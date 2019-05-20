using System.Collections.Generic;
using UnityEngine;


public class CardDeck : CardCollection{
 
    

    private Stack<Card> _deckOfCards = new Stack<Card>();// Contains all 52 cards
    

      
    public CardDeck()    // Constructor
    {
        Card card = GetCard(1);
        //shuffleDeck();

        Debug.Log("Called");

    }
    
    

      

    public Card DealCard()
    {
        Card topCard = _deckOfCards.Pop();
        return topCard;
    }
        
      
}