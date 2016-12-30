using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private AnimationManager animationManager;
    public float speed;
    public float jumpForce;

    private void Start()
    {
        animationManager = GetComponent<AnimationManager>();
    }
    public void MoveForward()
    {
       transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void Jump()
    {
       transform.Translate(Vector2.up * jumpForce * Time.deltaTime);
        animationManager.SetAnimation("isJumping");
         MusicController.Instance.PlayJump();
    }
}
