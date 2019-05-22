using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DeckPrefab : MonoBehaviour
{

    [FormerlySerializedAs("CardPrefab")] public GameObject cardPrefab;
    public Sprite kingOfHearts;
    //download it here https://opengameart.org/sites/default/files/styles/medium/public/king_of_hearts2.png
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {         
            GameObject cardInstance = Instantiate(cardPrefab, this.transform);
            //Debug.Log(cardInstance.GetComponent<Card>().suit);
            
            cardInstance.GetComponent<SpriteRenderer>().sprite = kingOfHearts;
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
