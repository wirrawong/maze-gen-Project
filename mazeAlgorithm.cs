using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. Create Initialise method
 2. Create CreateMaze method
 3. Create getCells property
 4. Create getRows property
 5. Create getColumns property
 6. Create getWallSize property
 7. Create getWallObject property
 */

public interface mazeAlgorithm
{
    void Initialise();
    void CreateMaze();

    MazeCell[,] getCells();
    int getRows();
    int getColumns();
    float getWallSize();
    GameObject getWallObject();
}
