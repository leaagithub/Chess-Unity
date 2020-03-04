using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

[System.Serializable]
public class SquareStyle
{
    public Texture NewTexture;
    //public Piece PieceClass
}


public class SquarePieceHold : MonoBehaviour
{
    public static SquarePieceHold instance;
    public SquareStyle[] squareStyle;

    void Awake()
    {
        instance = this;
    }

}