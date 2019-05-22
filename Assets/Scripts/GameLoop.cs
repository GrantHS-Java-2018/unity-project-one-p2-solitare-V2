using System.Collections;
using UnityEngine;


public class GameLoop : MonoBehaviour {
	
	//not sure if any of this code works

	
	
	Stack _drawPile= new Stack();
	Stack _drawPileClicked = new Stack();
	Stack _rowOne= new Stack();
	Stack _rowTwo= new Stack();
	Stack _rowThree= new Stack();
	Stack _rowFour= new Stack();
	Stack _rowFive= new Stack();
	Stack _rowSix= new Stack();
	Stack _rowSeven= new Stack();
	Stack _acesDiamond= new Stack();
	Stack _acesHearts= new Stack();
	Stack _acesClubs= new Stack();
	Stack _acesSpades= new Stack();
	Stack _movementSpace= new Stack();
	Stack _rowTwoFacedown= new Stack();
	Stack _rowThreeFacedown= new Stack();
	Stack _rowFourFacedown= new Stack();
	Stack _rowFiveFacedown= new Stack();
	Stack _rowSixFacedown= new Stack();
	Stack _rowSevenFacedown= new Stack();
	void Start ()
	{
		CardDeck deck = new CardDeck();
		
		
		int color;
		
		
		if (deck.IntToSuit.Equals(1))
		{
			color = 1;
		}
		
		//Hearts, Diamonds color =1
		//Spades, Clubs color=2
		//+ suit for the ace piles
		

		Shuffle();

		
	}

	public void Aces()
	{

		
	}

	//only interact with face up cards




	public void Shuffle()
	{
		var card = _drawPile.Pop();
		_rowOne.Push(card);
		card = _drawPile.Pop();
		_rowTwoFacedown.Push(card);
		card = _drawPile.Pop();
		_rowTwo.Push(card);
		
		for(var q = 0; q < 2; q++){
			card = _drawPile.Pop();
			_rowThreeFacedown.Push(card);}
		
		card = _drawPile.Pop();
		_rowThree.Push(card);
		
		for (var w = 0; w < 3; w++)
		{
			card = _drawPile.Pop();
			_rowFourFacedown.Push(card);
		}

		card = _drawPile.Pop();
		_rowFour.Push(card);
		
		for(var e = 0; e < 4; e++){
			card = _drawPile.Pop();
			_rowFiveFacedown.Push(card);}
		
		card = _drawPile.Pop();
		_rowFive.Push(card);
		
		for(var r = 0; r < 5; r++){
			card = _drawPile.Pop();
			_rowSixFacedown.Push(card);}
		
		card = _drawPile.Pop();
		_rowSix.Push(card);
		
		for(var t = 0; t < 6; t++){
			card = _drawPile.Pop();
			_rowSevenFacedown.Push(card);}
		
		card = _drawPile.Pop();
		_rowSeven.Push(card);

	}

	private void CheckLength()
	{
		object current;
		//Sense when stack for flipped cards is empty and shift stacks
		if(_rowTwo.Count==0){
			current = _rowTwoFacedown.Pop();
			_rowTwo.Push(current);
		}
		if(_rowThree.Count==0){
			current = _rowThreeFacedown.Pop();
			_rowThree.Push(current);
		}
		if(_rowFour.Count==0){
			current= _rowFourFacedown.Pop();
			_rowFour.Push(current);
		}
		if(_rowFive.Count==0){
			current = _rowFiveFacedown.Pop();
			_rowFive.Push(current);
		}
		if(_rowSix.Count==0){
			current = _rowSixFacedown.Pop();
			_rowSix.Push(current);
		}
		if(_rowSeven.Count==0){
			current = _rowSevenFacedown.Pop();
			_rowSeven.Push(current);
		}

	}



	//Deal in 7 rows, 1,2,3,4,5,6,7 cards each, only top card visible

	//only check if player moves card to the pile
	//does not apply to movement stack

	

	public bool Win()
	{
		bool win; 
		if(_acesDiamond.Count==13 && _acesHearts.Count==13  && _acesClubs.Count==13 
		   && _acesSpades.Count==13)
		{
			win = true;
		}
		else
		{
			win = false;
		}

		return win;
	}
}
