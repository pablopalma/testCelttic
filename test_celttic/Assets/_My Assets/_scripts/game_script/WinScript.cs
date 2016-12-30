using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour
{

    private Animator anim;

    private void OnEnable()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(EndGame());
    }

    private IEnumerator EndGame()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("isWaling", false);
        anim.SetBool("isWin", true);
    }
}
