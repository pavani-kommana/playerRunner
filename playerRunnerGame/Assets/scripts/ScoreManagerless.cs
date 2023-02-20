using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerless : MonoBehaviour
{
    public int coinValue = 1;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            ScoreManager.instance.changesScoreless(coinValue);
            Destroy(gameObject);
           
        }
    }
}
