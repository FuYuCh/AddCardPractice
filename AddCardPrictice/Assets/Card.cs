using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card
{
    private int _number;
    public float x;
    private Sprite _mySprite;

    public int Number
    {
        get => _number;
    }

    public float X
    {
        get => x;
        set => x = value;
    }

    public Sprite mySprite
    {
        get => _mySprite;
    }

    public Card(int vNumber, float vX, Sprite vmySprite)
    {
        this._number = vNumber;
        this.x = vX;
        this._mySprite = vmySprite;
    }

   
}
