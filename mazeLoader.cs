using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. Declare mazeRows 
 2. Declare mazeColumns
 3. Declare wall
 4. Declare and initialize size with 2.0
 5. In Start() declare and initialise instance of huntAndKillMazeAlgorithm
 6. Call Initialise()
 7. Call CreateMaze()
 */

public class mazeLoader : MonoBehaviour
{
    public int mazeRows, mazeColumns;
    public GameObject wall;
    public float size = 2f;

    // Use this for initialization
    void Start()
    {
        mazeAlgorithm ma = new huntAndKillMazeAlgorithm(mazeRows, mazeColumns, wall, size); //access through interface mazeAlgorithm
        ma.Initialise();
        ma.CreateMaze();
    }

}
