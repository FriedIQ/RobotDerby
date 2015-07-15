using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardSection : MonoBehaviour 
{
    int sectionHeight = 12;
    int sectionWidth = 12;

    float tileOffset = 0.5f;
    
    public GameObject tilePrefab;
    public List<BoardTile> boardTiles = new List<BoardTile>();

    public List<BoardTile> Tiles
    {
        get { return boardTiles; }
    }

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    public void BuildSection()
    {
        for(int i= 1; i <= sectionWidth; i++)
        {
            for (int j = 1; j <= sectionHeight; j++)
            {
                boardTiles.Add(BuildTile(i, j));
            }
        }
    }

    BoardTile BuildTile(float x, float y)
    {
        GameObject tile = Instantiate(tilePrefab, Vector3.zero, Quaternion.identity) as GameObject;
        tile.transform.parent = transform;
        tile.transform.localPosition = new Vector3((1.0f * x) - tileOffset, 0.0f, (1.0f * y) - tileOffset);
        return tile.GetComponent<BoardTile>();
    }
}
