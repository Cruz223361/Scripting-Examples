using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Declaring Variables
    // public Memeber/Gobal Varibles
    public float MoveSpeed = 10f;
    public int PlayerScore = 0;
    public string PlayerName = "John Doe";
    public bool IsPlayerActive = true;

    // Private Memeber/Gobal variables
    private float MaxSpeed = 100f;
    private int totalscore = 0;
    private string userName = "John007";
    private bool isGameover = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Declaring local variables 
        float horizontalInput = Input.GetAxis("Horizontal");
    }
    {

    }
    
}




