using UnityEngine;
using System.Collections;

public class EffectsManager : MonoBehaviour
{

    private static EffectsManager _instance;
    public static EffectsManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject _effectManager = new GameObject("_Effect Manager");
                DontDestroyOnLoad(_effectManager);
                _effectManager.AddComponent<EffectsManager>();
            }
            return _instance;
        }
    }

    public GameObject collectFx;
    public GameObject hitFx;

    public void ShowEffect(string effect)
    {
        switch (effect)
        {
            case "Enemy":
                hitFx.SetActive(true);
                break;
            case "Collect":
                collectFx.SetActive(true);
                break;
        }
    }
}
