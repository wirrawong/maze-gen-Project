using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. Declare and initialize bool visited = false
 2. Declare GameObject northWall
 3. Declare GameObject southWall
 4. Declare GameObject eastWall
 5. Declare GameObject westWall
 6. Declare GameObject floor
 */

public class MazeCell
{
    public bool visited = false;
    public GameObject northWall, southWall, eastWall, westWall, floor;
}
