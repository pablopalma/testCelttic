using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour
{
    private Animator anim;
    private string realizedAnim = "isWalking";

	// Use this for initialization
	void Start ()
	{
	    anim = GetComponent<Animator>();
	}

    public void SetAnimation(string animName)
    {
        switch (animName)
        {
            case "isWalking":
                anim.SetBool(realizedAnim, false);
                anim.SetBool(animName, true);
                realizedAnim = animName;
                break;
            case "isJumping":
                anim.SetBool(realizedAnim, false);
                anim.SetBool(animName, true);
                realizedAnim = animName;
                break;
        }
    }
	
}
