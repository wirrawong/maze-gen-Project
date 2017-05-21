using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. Declare mazeCells, mazeRows, mazeColumns, wall, size
 2. Declare and initialise currentRow with 0
 3. Declare and initialise currentColumn with 0
 4. Declare and initialise courseComplete with false
 5. Create huntAndKillMazeAlgorithm 
 6. Create an instance of mazeCells
 7. Set parameters using the property get methods
 8. Initialize mazeCells with parameters mazeRows and mazeColumn
    9. FOR r to/in mazeRows
        10. FOR c to/in mazeColumns
            11. IF  r ==0 and c == 0 THEN
            12. Instantiate floor of mazeCells at cell location
            13. Rename floor of mazeCells
            14. Set rotation of mazeCells
            15. Set scale of object
            16. Change renderer colour to red
            17. END IF;
            18. IF c equals 0 THEN
                19. Instantiate westWall of mazeCells at cell location
                20. Rename westWall 
                21. END IF
            22. Instantiate eastWall at cell location
            23. Rename eastWall
            24. IF r equals 0 THEN
                25. Instantiate northWall at location
                26. Rename northWall
                27. Rotate northWall
                28. END IF
            29. Instantiate southWall at location
            30. Rename southWall 
            31. Rotate southWall
        33. END FOR
    34. END FOR
 35. In CreateMaze method call HuntAndKill method
 36. In HuntAndKill method set mazeCells visited to true
    37. WHILE courseComplete is false THEN
        38. Call Kill method
        39. Call Hunt method
    40. END WHILE
 41. In Kill method
    42. WHILE RouteStillAvailable is true THEN
        43. Declare and initialize direction with Random number in range 1 to 4
        44. IF direction equals 1 AND CellsAvailable with input currentRow -1 and currentColumn is true THEN
            45. Run destroyWallIfItExists with input currentRow and currentColumn GameObject northWall 
            46. Run destroyWallIfItExists with input currentRow -1 and currentColumn GameObject southWall 
            47. decrement currentRow by 1
        48. ELSE IF direction equals 2 AND CellsAvailable with input currentRow +1 and currentColumn is true THEN
            49. Run destroyWallIfItExists with input currentRow and currentColumn GameObject southWall 
            50. Run destroyWallIfItExists with input currentRow +1 and currentColumn GameObject northWall
            51. increment currentRow by 1
        52. ELSE IF direction equals 3 AND CellsAvailable with input currentRow and currentColumn +1 is true THEN
            53. Run destroyWallIfItExists with input currentRow and currentColumn GameObject eastWall 
            54. Run destroyWallIfItExists with input currentRow and currentColumn +1 GameObject westWall 
            55. increment currentColumn by 1
        56. ELSE IF direction equals 4 AND CellsAvailable with input currentRow and currentColumn -1 is true THEN
            57. Run destroyWallIfItExists with input currentRow and currentColumn GameObject westWall 
            58. Run destroyWallIfItExists with input currentRow and currentColumn -1 GameObject eastWall 
            59. decrement currentColumn by 1
        60. END IF
    61. END WHILE
 62. In Hunt() set courseComplete to true
     62. FOR r to/in mazeRows
        63. FOR c to/in mazeColumns
            64. IF mazeCells visited is false AND CellHasAnAdjacentVisitedCell is true THEN 
                65. set courseComplete to false
                66. set currentRow to r
                67. set currentColumn to c
                68. Call DestroyAdjacentWall with input currentRow and currentColumn
                69. set mazeCells with input currentRow and currentColumn visited to true
                70. RETURN
                71. END IF
        72. END FOR
     73. END FOR
 74. In RouteStillAvailable() declare and initialise availableRoutes to 0
    75. IF row is greater than 0 AND mazeCells with input row -1 and column visited is false THEN
        76. increment availableRoutes
        77. END IF
    78. IF row is less than mazeRows -1 AND mazeCells with input row +1 and column visited is false THEN
        79. increment availableRoutes
        80. END IF
    81. IF column is greater than 0 AND mazeCells with input row and column -1 visited is false THEN
        82. increment availableRoutes
        83. END IF
    84. IF column is less than mazeColumns -1 AND mazeCells with input row and column +1 visited is false THEN
        85. increment availableRoutes
        86. END IF
    87. RETURN availableRoutes if greater than 0
 88. In CellsAvailable() IF row greater than or equal to 0 AND row is less than mazeRows AND column greater than or equal to 0 AND column is less than mazeColumns AND mazeCells with input mazeRows and mazeColumn visited is false THEN
    89. RETURN true
    90. ELSE RETURN false
    91. END IF
 92. In DestroyAdjacentWall() declare and initialise wallDestroyed as false
    93. WHILE wallDestroyed is false THEN
        94. Declare and initialize direction with Random number in range 1 to 4
        95. IF direction equals 1 AND row is greater than 0 AND mazeCells with input row -1 and column visited is true THEN
            96. Run destroyWallIfItExists with input row and column GameObject northWall 
            97. Run destroyWallIfItExists with input row -1 and column GameObject southWall 
            98. wallDestroyed set to true
        99. ELSE IF direction equals 2 AND row is less than mazeRows -2 AND mazeCells with input row +1 and column visited is true THEN
            100. Run destroyWallIfItExists with input row and column GameObject southWall 
            101. Run destroyWallIfItExists with input row +1 and column GameObject northWall
            102. wallDestroyed set to true
        103. ELSE IF direction equals 3 AND column is greater than 0 AND mazeCells with input row and column -1 visited is true THEN
            104. Run destroyWallIfItExists with input row and column GameObject westWall 
            105. Run destroyWallIfItExists with input row and column -1 GameObject eastWall 
            106. wallDestroyed set to true
        107. ELSE IF direction equals 4 AND column is less than mazeColumns -2 AND mazeCells with input row and column +1 visited is true THEN
            108. Run destroyWallIfItExists with input row and column GameObject eastWall 
            109. Run destroyWallIfItExists with input row and column +1 GameObject westWall 
            110. wallDestroyed set to true
        111. END IF
    112. END WHILE
 113. In DestroyWallIfItExists() IF wall is not equal to null THEN
    114. Destroy wall
    115. END IF
 116. In CellHasAnAdjacentVisitedCell() declare and initialise vistedCells with 0
 117. IF row is greater than 0 AND mazeCells with input row -1 and column visited is true THEN
    118. Increment visitedCells
    119. END IF
 120. IF row is less than mazeRows -2 AND mazeCells with input row +1 and column visited is true THEN
    121. Increment visitedCells
    122. END IF
 123. IF column is greater than 0 AND mazeCells with input row and column -1 visited is true THEN
    124. Increment visitedCells
    125. END IF
 126. IF column is less than mazeColumns -2 AND mazeCells with input row and column +1 visited is true THEN
    127. Increment visitedCells
    128. END IF
 129. RETURN visitedCells if greater than 0
 130. In getCells() RETURN mazeCells
 131. In getRows() RETURN mazeRows
 132. In getColumns() RETURN mazeCoulmns
 133. In getWallSize() RETURN size
 134. In getWallObject() RETURN wall
 */

public class huntAndKillMazeAlgorithm : mazeAlgorithm
{
    protected MazeCell[,] mazeCells;
    protected int mazeRows, mazeColumns;
    protected GameObject wall;
    protected float size;

    private int currentRow = 0;
    private int currentColumn = 0;

    private bool courseComplete = false;

    public huntAndKillMazeAlgorithm(int mazeRows, int mazeColumns, GameObject wall, float size) //set all the variables in runtime
    {
        this.mazeCells = new MazeCell[mazeRows, mazeColumns];
        this.mazeRows = mazeRows;
        this.mazeColumns = mazeColumns;
        this.size = size;
        this.wall = wall;
    }

    public void Initialise() //setting up grid of cells, walls get destroyed to create maze later
    {
        for (int r = 0; r < mazeRows; r++) //for maze row iteration
        {
            for (int c = 0; c < mazeColumns; c++) //for maze column iteration
            {
                mazeCells[r, c] = new MazeCell(); //save cell grid position in 2D array

                if(r == 0 && c == 0) //create one floor at origin point
                {
                    mazeCells[r, c].floor = GameObject.Instantiate(wall, new Vector3(((mazeRows - 1) * size)/ 2f, -(size/2f), ((mazeColumns - 1) * size) / 2f), Quaternion.identity) as GameObject;
                    mazeCells[r, c].floor.name = "Floor " + r + "," + c;
                    mazeCells[r, c].floor.transform.Rotate(Vector3.right, 90f);
                    mazeCells[r, c].floor.transform.localScale += new Vector3((mazeRows - 1) * size, (mazeColumns - 1) * size, 0.0f); //scale to cover whole maze
                    mazeCells[r, c].floor.GetComponent<Renderer>().material.color = Color.blue; //changed colour to make it easier to see
                }
                
                //walls are created this way to avoid doubling up of walls when it's not needed
                if (c == 0) //for the left column only to create the left border
                {
                    mazeCells[r, c].westWall = GameObject.Instantiate(wall, new Vector3(r * size, 0, (c * size) - (size / 2f)), Quaternion.identity) as GameObject;
                    mazeCells[r, c].westWall.name = "West Wall " + r + "," + c;

                }
                //always create east walls
                mazeCells[r, c].eastWall = GameObject.Instantiate(wall, new Vector3(r * size, 0, (c * size) + (size / 2f)), Quaternion.identity) as GameObject;
                mazeCells[r, c].eastWall.name = "East Wall " + r + "," + c;

                if (r == 0) //for the top row only to create the top border
                {
                    mazeCells[r, c].northWall = GameObject.Instantiate(wall, new Vector3((r * size) - (size / 2f), 0, c * size), Quaternion.identity) as GameObject;
                    mazeCells[r, c].northWall.name = "North Wall " + r + "," + c;
                    mazeCells[r, c].northWall.transform.Rotate(Vector3.up * 90f);
                }
                //always create south walls 
                mazeCells[r, c].southWall = GameObject.Instantiate(wall, new Vector3((r * size) + (size / 2f), 0, c * size), Quaternion.identity) as GameObject;
                mazeCells[r, c].southWall.name = "South Wall " + r + "," + c;
                mazeCells[r, c].southWall.transform.Rotate(Vector3.up * 90f);
            }
        }
    }

    public void CreateMaze()
    {
        HuntAndKill();
    }

    private void HuntAndKill()
    {
        mazeCells[currentRow, currentColumn].visited = true;

        while (!courseComplete)
        {
            Kill(); //until hits a dead end
            Hunt(); //finds new path

        }
    }

    private void Kill()
    {
        while (RouteStillAvailable(currentRow, currentColumn))
        {
            int direction = UnityEngine.Random.Range(1, 5);
            //does checks for wall that could be on same transform but in a different cell
            //north
            if (direction == 1 && CellsAvailable(currentRow - 1, currentColumn))
            {
                DestroyWallIfItExists(mazeCells[currentRow, currentColumn].northWall);
                DestroyWallIfItExists(mazeCells[currentRow - 1, currentColumn].southWall); 
                currentRow--;
            }
            //south
            else if (direction == 2 && CellsAvailable(currentRow + 1, currentColumn))
            {
                DestroyWallIfItExists(mazeCells[currentRow, currentColumn].southWall);
                DestroyWallIfItExists(mazeCells[currentRow + 1, currentColumn].northWall);
                currentRow++;
            }
            //east
            else if (direction == 3 && CellsAvailable(currentRow, currentColumn + 1))
            {
                DestroyWallIfItExists(mazeCells[currentRow, currentColumn].eastWall);
                DestroyWallIfItExists(mazeCells[currentRow, currentColumn + 1].westWall);
                currentColumn++;
            }
            //west
            else if (direction == 4 && CellsAvailable(currentRow, currentColumn - 1))
            {
                DestroyWallIfItExists(mazeCells[currentRow, currentColumn].westWall);
                DestroyWallIfItExists(mazeCells[currentRow, currentColumn - 1].eastWall);
                currentColumn--;
            }
            mazeCells[currentRow, currentColumn].visited = true;
        }
    }

    private void Hunt()
    {
        courseComplete = true; //set true and check if there is still something below

        for (int r = 0; r < mazeRows; r++)
        {
            for (int c = 0; c < mazeColumns; c++)
            {
                if (!mazeCells[r, c].visited && CellHasAnAdjacentVisitedCell(r, c))
                {
                    courseComplete = false; //found something left
                    currentRow = r;
                    currentColumn = c;
                    //start new path from this cell
                    DestroyAdjecentWall(currentRow, currentColumn);
                    mazeCells[currentRow, currentColumn].visited = true;
                    return;
                }
            }
        }
    }
    private bool RouteStillAvailable(int row, int column)
    {
        //looking for routes by checking cells that are unvisited
        int availableRoutes = 0;

        if (row > 0 && !mazeCells[row - 1, column].visited)
        {
            availableRoutes++;
        }
        if (row < mazeRows - 1 && !mazeCells[row + 1, column].visited)
        {
            availableRoutes++;
        }
        if (column > 0 && !mazeCells[row, column - 1].visited)
        {
            availableRoutes++;
        }
        if (column < mazeColumns - 1 && !mazeCells[row, column + 1].visited)
        {
            availableRoutes++;
        }
        return availableRoutes > 0;
    }

    private bool CellsAvailable(int row, int column)
    {
        if (row >= 0 && row < mazeRows && column >= 0 && column < mazeColumns && !mazeCells[row, column].visited)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void DestroyAdjecentWall(int row, int column)
    {
        bool wallDestroyed = false;

        while (!wallDestroyed)
        {
            int direction = UnityEngine.Random.Range(1, 5);
            //does checks for wall that could be on same transform but in a different cell
            //north
            if (direction == 1 && row > 0 && mazeCells[row - 1, column].visited)
            {
                DestroyWallIfItExists(mazeCells[row, column].northWall);
                DestroyWallIfItExists(mazeCells[row - 1, column].southWall);
                wallDestroyed = true;
            }
            //south
            else if (direction == 2 && row < (mazeRows - 2) && mazeCells[row + 1, column].visited)
            {
                DestroyWallIfItExists(mazeCells[row, column].southWall);
                DestroyWallIfItExists(mazeCells[row + 1, column].northWall);
                wallDestroyed = true;
            }
            //west
            else if (direction == 3 && column > 0 && mazeCells[row, column - 1].visited)
            {
                DestroyWallIfItExists(mazeCells[row, column].westWall);
                DestroyWallIfItExists(mazeCells[row, column - 1].eastWall);
                wallDestroyed = true;
            }
            //east
            else if (direction == 4 && column < (mazeColumns - 2) && mazeCells[row, column + 1].visited)
            {
                DestroyWallIfItExists(mazeCells[row, column].eastWall);
                DestroyWallIfItExists(mazeCells[row, column + 1].westWall);
                wallDestroyed = true;
            }
        }
    }
    private void DestroyWallIfItExists(GameObject wall)
    {
        if (wall != null)
        {
            GameObject.Destroy(wall);
        }
    }

    private bool CellHasAnAdjacentVisitedCell(int row, int column)
    {
        int visitedCells = 0;
        //Look north if we're at row 1 or more
        if (row > 0 && mazeCells[row - 1, column].visited)
        {
            visitedCells++;
        }

        //Look south if we're at the 2nd last row or less
        if (row < (mazeRows - 2) && mazeCells[row + 1, column].visited)
        {
            visitedCells++;
        }

        //Look west if we're at coloumn 1 or more
        if (column > 0 && mazeCells[row, column - 1].visited)
        {
            visitedCells++;
        }

        //Look east if we're at the 2nd last column or less
        if (column < (mazeColumns - 2) && mazeCells[row, column + 1].visited)
        {
            visitedCells++;
        }
        //return if there are adjecent cells
        return visitedCells > 0;
    }
    //property return
    public MazeCell[,] getCells()
    {
        return mazeCells;
    }

    public int getRows()
    {
        return mazeRows;
    }

    public int getColumns()
    {
        return mazeColumns;
    }

    public float getWallSize()
    {
        return size;
    }

    public GameObject getWallObject()
    {
        return wall;
    }
}
