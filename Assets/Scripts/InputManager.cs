using System;
using UnityEngine;
using UnityEngine.InputSystem;

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

    private GameObject playerInputManager;
    private PlayerInputManager playerInputManagerComponent;
    public GameObject nextPlayerPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInputManager = GameObject.Find("PlayerManager");
        playerInputManagerComponent = playerInputManager.GetComponent<PlayerInputManager>();
        playerInputManagerComponent.playerPrefab = nextPlayerPrefab;
    }

    void OnMove(InputAction.CallbackContext context)
    {
        Vector2 move = context.ReadValue<Vector2>();
        Debug.Log("MOVED");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
