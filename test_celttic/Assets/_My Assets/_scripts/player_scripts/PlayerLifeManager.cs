using UnityEngine;
using System.Collections;


public class PlayerLifeManager : MonoBehaviour
{
    public GameObject[] heartsLife;
    private int lifeAmount = 0;

    private  int indexLife = 3;
    public void DecreasePlayerLife()
    {
        indexLife -=1;
        heartsLife[indexLife].SetActive(false);

        if (indexLife <= 0)
        {
            gameObject.SetActive(false);     
            SceneState.Instance.SetScene("gameover");    
        }
    }
}
