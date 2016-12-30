using UnityEngine;
using System.Collections;

public class CollectableScript : MonoBehaviour
{
    private EffectsManager effects;

    private void Awake()
    {
        effects = GameObject.FindObjectOfType<EffectsManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collect")
        {
            effects.ShowEffect("Collect");
            other.gameObject.SetActive(false);
            ScoreManager.IncreaseScore(1);
            MusicController.Instance.PlayCorrectSound();
        }
        else if (other.tag == "Enemy")
        {
            effects.ShowEffect("Enemy");
            other.gameObject.SetActive(false);
            MusicController.Instance.PlayIncorrectSound();
        }
    }
}
