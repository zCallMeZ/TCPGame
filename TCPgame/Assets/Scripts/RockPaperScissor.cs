using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockPaperScissor : MonoBehaviour
{
    [SerializeField] private TestMeshProUGUI txt;
    [SerializeField] private TestMeshProUGUI result;

    void Random()
    {
        int x = Random.Range(0, 2);
        if (x == 0) { txt.text = "Rock"; }
        if (x == 1) { txt.text = "Paper"; }
        if (x == 2) { txt.text = "Scissor"; }
    }

    public void Rock()
    {
        Random();
        if (txt.text == "Rock") { result.text = "Match tied"; }
        if (txt.text == "Paper") { result.text = "You Lose"; }
        if (txt.text == "Scissor") { result.text = "You WIN"; }
    }

    public void Paper()
    {
        Random();
        if (txt.text == "Paper") { result.text = "Match tied"; }
        if (txt.text == "Scissor") { result.text = "You Lose"; }
        if (txt.text == "Rock") { result.text = "You WIN"; }
    }

    public void Scissor()
    {
        Random();
        if (txt.text == "Scissor") { result.text = "Match tied"; }
        if (txt.text == "Rock") { result.text = "You Lose"; }
        if (txt.text == "Paper") { result.text = "You WIN"; }
    }
}
