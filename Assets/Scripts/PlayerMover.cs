using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private CharacterController controller;


    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    private void AutoMove()
    {

    }
    
    void Update()
    {
        
    }
}
