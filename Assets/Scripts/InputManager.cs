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
    
    private PlayerInput playerInput;
    private GameObject playerInputManager;
    private PlayerInputManager playerInputManagerComponent;
    public GameObject nextPlayerPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInputManager = GameObject.Find("PlayerManager");
        playerInputManagerComponent = playerInputManager.GetComponent<PlayerInputManager>();
        playerInput = GetComponent<PlayerInput>();
        playerInputManagerComponent.playerPrefab = nextPlayerPrefab;
    }

    void OnMove(InputValue value)
    {
        Vector2 move = value.Get<Vector2>();
        transform.position += new Vector3(move.x, 0, move.y) * Time.deltaTime;
        Debug.Log("MOVED");
    }


    void OnAttack()
    {
        // todo logic
    }
     
    void OnHeavyAttack()
    {
        // todo logic
    }
    void OnJump()
    {
        // todo logic
    }

    // Update is called once per frame
    void Update()
    {
       //todo make turnAround logic 
    }
}
