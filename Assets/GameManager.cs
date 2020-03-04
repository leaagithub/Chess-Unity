using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    //public GameState State;
    private bool moveMade;

    private Square[,] AllSquares = new Square[8, 8];
    private List<Square[]> columns = new List<Square[]>();
    private List<Square[]> rows = new List<Square[]>();
    private List<Square> EmptySquares = new List<Square>();

    void Start()
    {
        Square[] AllSquaresOneDim = GameObject.FindObjectsOfType<Square>();
        foreach (Square t in AllSquaresOneDim)
        {
            t.PieceTextureNumber = 0;
            AllSquares[t.indRow, t.indCol] = t;
            EmptySquares.Add(t);
        }
    }

    void Update()
    {

    }
}
