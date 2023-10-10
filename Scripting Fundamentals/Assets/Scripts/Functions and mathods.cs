using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functionsandmathods : MonoBehaviour
{
    // Functions re blocks of code that perform specific task and are not associated with any specfic object or class. The can be called and
    // executed independly


    // methods, onthe other hand, are functions that
    //are assciated with a specific object or class.They can be called and executed on instances of that object or class.

    //Declare our varibles 
    private AudioSource audiosource;
    private float speed = 10f;
    private int playerHealthAmount = 100;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // creating some simple functions

    // Function to play a sound effect
    private void PlaySoundEffect(AudioClip soundEffect)
    {
      audiosource.PlayOneShot(soundEffect);

    }

     // Function to detect Triggers
     private void OnTriggerEnter(Collider other)
}

