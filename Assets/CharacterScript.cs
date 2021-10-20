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
        }
        if (collision.gameObject.tag == "water")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(score == 50)
        {
            SceneManager.LoadScene("WinScene");
        }
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
