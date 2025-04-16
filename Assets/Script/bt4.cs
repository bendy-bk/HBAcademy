using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Forward,
    Back,
    Left,
    Right
}

public class bt4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintDirection(Direction.Forward);
        PrintDirection(Direction.Back);
        PrintDirection(Direction.Left);
        PrintDirection(Direction.Right);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PrintDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Forward:
                Debug.Log("in ra trước");
                break;
            case Direction.Back:
                Debug.Log("in ra sau");
                break;
            case Direction.Left:
                Debug.Log("in ra trái");
                break;
            case Direction.Right:
                Debug.Log("in ra phải");
                break;
            default:
                Debug.Log("Không xác định hướng!");
                break;
        }
    }
}
