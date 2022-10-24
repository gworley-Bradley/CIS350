using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject[] hiddenExits;
    public Text scoreText;
    public int skeletons = 0;
    public int coins = 0;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!won)
        {
            scoreText.text = "Coins: " + coins + "\n" + "Skeletons: " + skeletons;
        }
        if (won)
        {
            scoreText.text = "You Win!" + "\n" + "Press R to Try Again!";
        }

        if (won && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        if (coins == 5 && skeletons == 10)
        {
            hiddenExits = GameObject.FindGameObjectsWithTag("Final");
            for (int i = hiddenExits.Length - 1; i >= 0; i--)
            {
                Destroy(hiddenExits[i].gameObject);
            }
        }

        
    }
}
