using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Controls controls;
    public enum playerState
    {
        up,
        left,
        down,
        right,
        none
    }

    public playerState playerOne;
    public playerState playerTwo;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controls = new ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
