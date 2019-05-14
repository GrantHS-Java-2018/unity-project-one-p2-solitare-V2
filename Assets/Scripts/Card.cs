using UnityEngine;

public class Card : MonoBehaviour
{

    public enum Suit
    {
        Diamond = 0,
        Club = 1,
        Heart = 2,
        Spade = 3
    }

    public enum Rank
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public Card()
    {
	
        CardSuit = CardSuitMethod(1);
        CardRank = CardRankMethod(2);
		
		
    }

    private Suit CardSuit { get; set; }

    private Rank CardRank { get; set; }


    public Card.Suit CardSuitMethod (int suit)
    {
        switch (suit)
        {
            case 0:
                CardSuit = Suit.Diamond;
                break;
            case 1:
                CardSuit = Suit.Club;
                break;
            case 2:
                CardSuit = Suit.Heart;
                break;
            case 3:
                CardSuit = Suit.Spade;
                break;
            default:
                Debug.Log("Invalid suit");
                break;	
        }
		

        Debug.Log(CardSuit);
        return CardSuit;
		
    }
	
    public Card.Rank CardRankMethod (int rank)
    {
        switch (rank)
        {
            case 1:
                CardRank = Rank.Ace;
                break;
            case 2:
                CardRank = Rank.Two;
                break;
            case 3:
                CardRank = Rank.Three;
                break;
            case 4:
                CardRank = Rank.Four;
                break;
            case 5:
                CardRank = Rank.Five;
                break;
            case 6:
                CardRank = Rank.Six;
                break;
            case 7:
                CardRank = Rank.Seven;
                break;
            case 8:
                CardRank = Rank.Eight;
                break;
            case 9:
                CardRank = Rank.Nine;
                break;
            case 10:
                CardRank = Rank.Ten;
                break;
            case 11:
                CardRank = Rank.Jack;
                break;
            case 12:
                CardRank = Rank.Queen;
                break;
            case 13:
                CardRank = Rank.King;
                break;
            default:
                Debug.Log("Invalid rank");
                break;	
        }

        Debug.Log(rank);
        return CardRank;
    }


    private void Update()
    {

    }

}
