using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject card;
    // Use this for initialization
    void Start ()
    {
        Instantiate(card);
		
    }
	
	

}

//Use Fenger's code example for reference on making the card decks