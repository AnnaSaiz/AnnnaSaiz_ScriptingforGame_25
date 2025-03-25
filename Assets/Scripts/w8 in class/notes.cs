using UnityEngine;

public class notes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //for(int i = 0; i < cubes.Count; i++)
        // {
        //   Debug.Log(cubes[i].name);
        //
        //    if(i % 2 == 0)
        //   {
        //     Debug.Log(cubes[i].name + "is an even element")
        //   }
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//DATATYPES

//NUMBERS

//int = whole number
//float = decimal


//WORDS
//--------

//Char = single characters "A" "," "$"
//String = multiple characters "words"

//Vector3 = 3 floats represented by x,y,z
//transform = access to position, rotation, scale
//Gameobject = access to tags, Getcomponents, layers, setting active/ inactive ect;

//bool = true or false, 1 or 0, 

//CONDITIONALS
//--------

//set a variable  this = that
//check a variable  (is) this == that (?) are they the same (applys to lots of things)
// if (this <= that) numbers
// if (this >= that) numbers
// ++ add to integer?


//FUNCTIONS
//--------

//blocks of code to run together

//Start() - Runs the first time the object the script is on is active and enabled
//Update() - runs every frame the object is active and enabled

//OnTriggerEnter() - Runs when an object with a rigidbody collides with a collider marked as a trigger
//OnCollisionEnter() - Smae as above but not marked as trigger

//IEnumerator - to call coroutine
//Coroutine - a way to sequence code in a very nice way, can suspend and resume code by time

//CUSTOM FUNCTIONS
//--------

//we have to call these ourselves, we can call them from wherever in code but must specify when and what it does.
//Unity specific functions are typically the starting point of custom functions
//Functions can be called in other functions
//All code being run from non-coroutines must reach the end of code before the frame is allowed to end

//INVOKING FUNCTIONS
//--------

//allows us to call a function after x amount of time
//once invoked, will run code until end

//Invoke("FunctionName", timeUntilStart);

//PHYSICS 
//--------

//OnTriggerEnter() - Runs when an object with a rigidbody collides with a collider marked as a trigger
//OnCollisionEnter() - Smae as above but not marked as trigger
// RayCast - Ray - looksie loo

//LISTS
//--------

// using System.collections.generic
// lists allow us to hold reference to multiples of a datatype
//Ex: Public List<GameObject> cubes;

//can refernce individually by element assigned in inspector
// cubes[0] - ref to first gameobject in the list

// cubes[0].SetActive(false);  first one in list will be set false
//cubes[cubes.Count -1].SetActive(false);  last one in list will be set to false when game starts


//FOR EACH
//--------

// foreach(GameObject <name> in list) 

// foreach(GameObject <c> in cubes)
// {
//   Debug.Log(c.name); //display name of each individual item in list
// }


//FOR
//-------

// for( int i = 0)

// initializing a variable, typically used to track current list index

// i < cubes.Count;
// is conditional, if this is true on ear=ch round of the loop it will run the code

// i ++
// incraments variable, each time we go through the loop it's the next index in the list

// if(i % 2 == 0) is i even?
// if(i % 2 == 1) is i odd?

// % = division? i think


//REFERENCING SCRIPTS
//-------

// public NameOfRefScript variable; -- making the variable

// if( variable.otherScriptFunction == true) -- reference variable from other script






