using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public int up;
    public int down;
    public TextMeshProUGUI scoreText;
    [SerializeField] private int blocks;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
            blocks += 1;
            scoreText.text = "Blocks: " + blocks;
            other.gameObject.SetActive(false);
        }
        
        if (other.gameObject.CompareTag("Fore"))
        {
            SceneManager.LoadScene(up);
        }
        
        if (other.gameObject.CompareTag("Back"))
        {
            SceneManager.LoadScene(down);
        }
    }
}
