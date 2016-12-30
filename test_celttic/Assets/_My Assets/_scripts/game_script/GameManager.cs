using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private EffectsManager effectsManager;
    #region Public Variables
    public float levelTime;
    public Text timeTxt;
    #endregion

    private void Start()
    {
        effectsManager = GameObject.FindObjectOfType<EffectsManager>();
    }

    private void Update()
    {
        levelTime -= Time.deltaTime;
        timeTxt.text = "Time: " + levelTime.ToString("0");
        if (levelTime <= 0)
        {
            SceneState.Instance.SetScene("win");
        }
    }

   
}
