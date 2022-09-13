using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Var chestScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish") && chestScore.value > 7)
        {
            SceneManager.LoadScene(2);
        }
    }
}
