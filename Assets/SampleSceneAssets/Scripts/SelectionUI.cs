using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionUI : MonoBehaviour
{
    public MenuManager menuManager;

    public Vector2Int posOnMap;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        foreach (var interaction in InputManager.forwardKeys)
        {
            if (Input.GetKeyDown(interaction))
            {
                MoveMapPosition(new Vector2Int(0,-1));
                break;
            }
        }
        foreach (var interaction in InputManager.LeftKeys)
        {
            if (Input.GetKeyDown(interaction))
            {
                MoveMapPosition(new Vector2Int(-1,0));
                break;
            }
        }
        foreach (var interaction in InputManager.backWardKeys)
        {
            if (Input.GetKeyDown(interaction))
            {
                MoveMapPosition(new Vector2Int(0,1));
                break;
            }
        }
        foreach (var interaction in InputManager.rightKeys)
        {
            if (Input.GetKeyDown(interaction))
            {
                MoveMapPosition(new Vector2Int(1,0));
                break;
            }
        }
    }

    public void MoveMapPosition(Vector2Int vector2Int)
    {
        if (menuManager.currentMap.map.GetLength(0) > posOnMap.x + vector2Int.x)
        {
            if (posOnMap.x + vector2Int.x >= 0)
            {
                posOnMap.x += vector2Int.x;
            }
            else
            {
                posOnMap.x = menuManager.currentMap.map.GetLength(0) - 1;
            }
        }
        else
        {
            posOnMap.x = 0;
        }

        if (menuManager.currentMap.map.GetLength(1) > posOnMap.y + vector2Int.y)
        {
            if (posOnMap.y + vector2Int.y >= 0)
            {
                posOnMap.y += vector2Int.y;
            }
            else
            {
                posOnMap.y = menuManager.currentMap.map.GetLength(1) - 1;
            }
        }
        else
        {
            posOnMap.y = 0;
        }
        
        GetComponent<RectTransform>().position = menuManager.currentMap.map[posOnMap.x, posOnMap.y].position;
        //Debug.Log(vector2Int + " -> " + posOnMap);
    }
}
