using UnityEngine;
using System.Collections;

public class BoardManager : MonoBehaviour 
{
    private static BoardManager _instance;

    GameObject gameBoard;
    public GameObject tilePrefab;

    public GameObject GameBoard 
    {
        get { return gameBoard; }
    }

	// Use this for initialization
	void Start () 
    {
        gameBoard = new GameObject("GameBoard");
        BuildBoard();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    public static BoardManager instance
    {
        get
        {
            //If _instance hasn't been set yet, we grab it from the scene!
            //This will only happen the first time this reference is used.
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<BoardManager>();
            return _instance;
        }
    }

    public void BuildBoard()
    {
        GameObject boardSection = new GameObject("BoardSection");
        boardSection.transform.parent = gameBoard.transform;
        BoardSection section = boardSection.AddComponent<BoardSection>();
        section.tilePrefab = tilePrefab;
        section.BuildSection();
    }
}
