using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour
{
    public int indRow;
    public int indCol;

    public int PieceTextureNumber
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            if (number == 0)
                SetEmpty();
            else
            {
                ApplyStyleFromHolder(number);
                SetVisible();
            }
        }
    }
    private int number;
    private Canvas SquareCanvas;
    private RawImage PieceTexture;

    private void Awake()
    {
        PieceTexture = GetComponentInChildren<RawImage>();
        SquareCanvas = GetComponentInChildren<Canvas>();
    }

    void ApplyStyleFromHolder(int index)
    {
        PieceTexture.texture = SquarePieceHold.instance.squareStyle[index].NewTexture;
    }
    private void SetVisible()
    {
        SquareCanvas.enabled = true;
        PieceTexture.enabled = true;
    }
    private void SetEmpty()
    {
        SquareCanvas.enabled = false;
        PieceTexture.enabled = false;
    }
}