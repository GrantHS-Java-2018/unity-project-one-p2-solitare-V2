

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking.Match;

public class Trial : CardCollection
{
    private void Start()
    {
        DeckOfCards();
    }

    public Card.Suit[] intToSuit = {
        
        Card.Suit.Diamond,
        Card.Suit.Club,
        Card.Suit.Heart,
        Card.Suit.Spade
    };
    
    public Card.Rank[] intToRank = {
        Card.Rank.Two,
        Card.Rank.Three,
        Card.Rank.Four,
        Card.Rank.Five,
        Card.Rank.Six,
        Card.Rank.Seven,
        Card.Rank.Eight,
        Card.Rank.Nine,
        Card.Rank.Ten,
        Card.Rank.Jack,
        Card.Rank.Queen,
        Card.Rank.King,
        Card.Rank.Ace
    };

  
   
    private ArrayList deckOfCards = new ArrayList();// Contains all 52 cards
    
    public void DeckOfCards()    // Constructor
    {
        for ( int suit = 0; suit < 4; suit++ ) {
            for (int rank = 0; rank < 13; rank++) {
                deckOfCards.Add(intToSuit[suit]);
                deckOfCards.Add(intToRank[rank]);
                Debug.Log(deckOfCards);
            }
        }
         shuffleDeck();
    }
    
    public void shuffleDeck()
    {
        //Collections.shuffle(deckOfCards);
    }
    
    public Card dealCard()
    {
        Card topCard = deckOfCards.Add(intToRank[1]);
        deckOfCards.Remove(0);
        return topCard;
    }
}
