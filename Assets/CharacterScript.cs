using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CharacterScript : MonoBehaviour
{
     public int score;
     public GameObject scoreText;
    
    
    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Coin")
        {
            
            Destroy(collision.gameObject);
            score += 10;
            scoreText.GetComponent<Text>().text = "Score: " + score;
        }

        if (collision.gameObject.tag == "Water")
        {
             SceneManager.LoadScene("LoseScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (score == 60)
        {
            SceneManager.LoadScene("WinScene");
        }
        
    }
}
