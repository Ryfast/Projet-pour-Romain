using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject card;
    public GameObject board;
    
    public Vector3 v;
    public Vector3 positionDansLaMain;


    public int carteMax = 6;

    private float ecart = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        //Creation du board
        GameObject plateau = GameObject.Instantiate(board, board.transform.position, board.transform.rotation);

        //Pioche au début de jeu
        v = Vector3.zero;
        for (int i = 0; i <= carteMax; i++)
        {
            GameObject carte = GameObject.Instantiate(card, v, card.transform.rotation);
            v = new Vector3(v.x + ecart, v.y, v.z);
            positionDansLaMain = carte.transform.position;
            carte.GetComponent<Cards>().maPosition = positionDansLaMain;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
