using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    private int score=0;
    public bool isGameOver=false;
    void Awake()
    {
        if(instance==null)
        {
            instance=this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score+=1;
        scoreText.text="Score"+score;

        if(score%10==0)
        {
              PoopSpawner spawner=FindObjectOfType<PoopSpawner>();
              if(spawner!=null)
              {
                spawner.DecreasePoopInterval();
                Debug.Log("Level Upgrade");
              }
        }
    }

    public void SetGameOver()
    {
        if(isGameOver==false)
        {
            isGameOver=true;
            PoopSpawner spanwer=FindObjectOfType<PoopSpawner>();
            if(spanwer!=null)
            {
                spanwer.StopSpawning();
            }
        }
    }
    
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
