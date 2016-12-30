using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneState : MonoBehaviour {

    private static SceneState _instance;
    public static SceneState Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject _SceneManager = new GameObject("_SceneManager");
                DontDestroyOnLoad(_SceneManager);
                _instance = _SceneManager.AddComponent<SceneState>();
            }

            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }


    public void SetScene(string scene)
    {
        switch (scene)
        {
            case "gameplay":
                SceneManager.LoadSceneAsync("gameplay");
                break;
            case "gameover":
                SceneManager.LoadScene("gameover");
                break;
            case "menu":
                SceneManager.LoadScene("menu");
                break;
            case "win":
                SceneManager.LoadScene("win");
                break;
        }
    }
}
