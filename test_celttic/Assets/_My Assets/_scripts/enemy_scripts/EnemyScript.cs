using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    private PlayerLifeManager lifePlayerLifeManager;
    public float speed;
    public float timeToDestroy;
    private bool isSpawned;
    public float forceJumpSpawn;

    private void OnEnable()
    {
        this.lifePlayerLifeManager = GameObject.FindObjectOfType<PlayerLifeManager>();
        //StartCoroutine(AutoDestroyEnemy());
        transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0, forceJumpSpawn);
    }

    private void StartMove()
    {
        isSpawned = true;
    }

    private void Update()
    {
        if (isSpawned)
        {
            MoveForward();
        }
     
    }
    public void MoveForward()
    {
        transform.Translate(-Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            lifePlayerLifeManager.DecreasePlayerLife();
            this.gameObject.SetActive(false);
        }
    }
}
