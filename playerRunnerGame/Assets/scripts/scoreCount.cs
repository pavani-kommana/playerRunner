using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCount : MonoBehaviour
{
    public int coinValue = 1;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
            {
             ScoreManager.instance.changescore(coinValue);
               Destroy(gameObject);
        }
    }
}
