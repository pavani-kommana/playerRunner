using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI Text;
    int score = 0;
    public int greenpicks;
    public int currentpicks= 0;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void changescore(int coinVal)
    {
        score = score + 1;
        Text.text = " "+score.ToString();
        currentpicks = currentpicks + 1;
        if (greenpicks==currentpicks)
        {
            SceneManager.LoadScene(1);
        }
       
    }
    public void changesScoreless(int coinVal)
    {
        score =score-1;
        Text.text = " " + score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
