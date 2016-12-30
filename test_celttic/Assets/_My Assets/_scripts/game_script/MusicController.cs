using UnityEngine;
using System.Collections;


public class MusicController : MonoBehaviour
{

    public AudioSource audioSourceMusic;
    public AudioSource audioSourceCorrect;
    public AudioSource audioSourceIncorrect;
    public AudioSource audioSourcePlayBtn;
    public AudioSource audioSourceJump;

    private static MusicController _instance = new MusicController();

    public static MusicController Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject _musicController = new GameObject("_MusicController");
                DontDestroyOnLoad(_musicController);
                _instance = _musicController.AddComponent<MusicController>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void PlayCorrectSound()
    {
        audioSourceCorrect.Play();
    }
    public void PlayIncorrectSound()
    {
        audioSourceIncorrect.Play();
    }

    public void PlayGameBtn()
    {
        audioSourcePlayBtn.Play();
    }

    public void PlayJump()
    {
        audioSourceJump.Play();
    }
}
