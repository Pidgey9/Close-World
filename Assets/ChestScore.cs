using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChestScore : MonoBehaviour
{
    TextMeshProUGUI text;
    public Var chestScore;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        chestScore.value = 0;
    }
    private void Update()
    {
        text.text = chestScore.value + "/8";
    }
}
