using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BtnScript : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
    
}
