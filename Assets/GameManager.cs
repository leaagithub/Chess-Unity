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

        AllSquares[0, 0].PieceTextureNumber = 12;
        AllSquares[0, 1].PieceTextureNumber = 9;
        AllSquares[0, 2].PieceTextureNumber = 7;
        AllSquares[0, 3].PieceTextureNumber = 11;
        AllSquares[0, 4].PieceTextureNumber = 8;
        AllSquares[0, 5].PieceTextureNumber = 7;
        AllSquares[0, 6].PieceTextureNumber = 9;
        AllSquares[0, 7].PieceTextureNumber = 12;

        AllSquares[7, 0].PieceTextureNumber = 6;
        AllSquares[7, 1].PieceTextureNumber = 3;
        AllSquares[7, 2].PieceTextureNumber = 1;
        AllSquares[7, 3].PieceTextureNumber = 5;
        AllSquares[7, 4].PieceTextureNumber = 2;
        AllSquares[7, 5].PieceTextureNumber = 1;
        AllSquares[7, 6].PieceTextureNumber = 3;
        AllSquares[7, 7].PieceTextureNumber = 6;

        for (int i = 0; i <8; ++i)
        {
            AllSquares[1, i].PieceTextureNumber = 10;
            AllSquares[6, i].PieceTextureNumber = 4;
        }


    }

    void Update()
    {

    }
}
