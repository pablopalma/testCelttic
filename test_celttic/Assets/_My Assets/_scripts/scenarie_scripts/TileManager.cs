using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public GameObject[] enemyPrefab;
    public GameObject currentTile;

    private static TileManager _instance;

    private Stack<GameObject> leftTiles = new Stack<GameObject>();
    private Stack<GameObject> topTiles = new Stack<GameObject>();
    public Stack<GameObject> enemyTile = new Stack<GameObject>();

    public Stack<GameObject> LeftTiles
    {
        get { return leftTiles; }
        set { leftTiles = value; }
    }

    public Stack<GameObject> TopTiles
    {
        get { return topTiles; }
        set { topTiles = value; }
    }

    public static TileManager Instance
    {
        get
        {
            DontDestroyOnLoad(_instance);
            return _instance ?? (_instance = GameObject.FindObjectOfType<TileManager>());

        }
    }

    private void OnEnable()
    {
        CreateTile(100);
        for (int i = 0; i < 50; i++)
        {
            SpawnTile();
        }
    }

    public void CreateTile(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            leftTiles.Push(Instantiate(tilePrefab[0]));
            topTiles.Push(Instantiate(tilePrefab[1]));

            leftTiles.Peek().name = "LeftTile";
            leftTiles.Peek().SetActive(false);

            topTiles.Peek().name = "TopTile";
            topTiles.Peek().SetActive(false);
        }
    }

    public void SpawnTile()
    {
        if (leftTiles.Count == 0 || topTiles.Count == 0)
        {
            CreateTile(10);
        }
        int randomIndex = Random.Range(0, 2);

        if (randomIndex == 0)
        {
            GameObject tmp = leftTiles.Pop();
            tmp.SetActive(true);
            tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
            currentTile = tmp;
        }
        else if (randomIndex == 1)
        {
            GameObject tmp = topTiles.Pop();
            tmp.SetActive(true);
            tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
            currentTile = tmp;
        }
    }
}
