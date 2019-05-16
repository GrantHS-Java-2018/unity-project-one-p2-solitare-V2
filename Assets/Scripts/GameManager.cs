using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject card;
    // Use this for initialization
    void Start ()
    {
        Instantiate(card);
		
    }

    private void OnValidate()
    {
	    throw new System.NotImplementedException();
	    var card1= new Card();
	    var card2 = card1 - 1;
	    
    }
}

//Use Fenger's code example for reference on making the card decks