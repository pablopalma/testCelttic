using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

    public float fallDelay = 1.4f;
    private TileManager tileManager;

    private void OnEnable()
    {
        tileManager = GameObject.FindObjectOfType<TileManager>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //TileManager.Instance.SpawnTile();
            tileManager.SpawnTile();
            StartCoroutine(FallDown());
        }
    }

    private IEnumerator FallDown()
    {
        yield return new WaitForSeconds(fallDelay);
        this.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
        yield return new WaitForSeconds(2);

        switch (gameObject.name)
        {
            case "LeftTile":
                tileManager.LeftTiles.Push(gameObject);
                this.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                gameObject.SetActive(false);
                break;

            case "TopTile":
                tileManager.TopTiles.Push(gameObject);
                this.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                gameObject.SetActive(false);
                break;

        }
    }
}
