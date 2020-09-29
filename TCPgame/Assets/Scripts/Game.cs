using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject rock;
    [SerializeField] private GameObject paper;
    [SerializeField] private GameObject scissor;

    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;
    [SerializeField] private GameObject tied;

    int player1;
    int player2;

    private void Update()
    {
        // Player 1 win
        if (player1 == 0 && player2 == 2)
        {
            win.SetActive(true);
            lose.SetActive(false);
            tied.SetActive(false);
        }
        if (player1 == 2 && player2 == 1)
        {
            win.SetActive(true);
            lose.SetActive(false);
            tied.SetActive(false);
        }
        if (player1 == 1 && player2 == 0)
        {
            win.SetActive(true);
            lose.SetActive(false);
            tied.SetActive(false);
        }

        // Player 2 win
        if (player2 == 0 && player1 == 2)
        {
            win.SetActive(true);
            lose.SetActive(false);
            tied.SetActive(false);
        }
        if (player2 == 2 && player1 == 1)
        {
            win.SetActive(true);
            lose.SetActive(false);
            tied.SetActive(false);
        }
        if (player2 == 1 && player1 == 0)
        {
            win.SetActive(true);
            lose.SetActive(false);
            tied.SetActive(false);
        }
        // Tied
        if (player1 == 0 & player2 == 0)
        {
            win.SetActive(false);
            lose.SetActive(false);
            tied.SetActive(true);
        }
        if (player1 == 1 & player2 == 1)
        {
            win.SetActive(false);
            lose.SetActive(false);
            tied.SetActive(true);
        }
        if (player1 == 2 & player2 == 2)
        {
            win.SetActive(false);
            lose.SetActive(false);
            tied.SetActive(true);
        }
    }

    private void RandomNmb()
    {
        player2 = Random.Range(0, 2);
    }

    public void Rock()
    {
        player1 = 0;
        RandomNmb();
    }

    public void Paper()
    {
        player1 = 1; 
        RandomNmb();
    }

    public void Scissor()
    {
        player1 = 2;
        RandomNmb();
    }
}
