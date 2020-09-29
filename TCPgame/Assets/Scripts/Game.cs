using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject rock;
    [SerializeField] private GameObject paper;
    [SerializeField] private GameObject scissor;

    [SerializeField] private GameObject rock2;
    [SerializeField] private GameObject paper2;
    [SerializeField] private GameObject scissor2;

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
            win.SetActive(false);
            lose.SetActive(true);
            tied.SetActive(false);
        }
        if (player2 == 2 && player1 == 1)
        {
            win.SetActive(false);
            lose.SetActive(true);
            tied.SetActive(false);
        }
        if (player2 == 1 && player1 == 0)
        {
            win.SetActive(false);
            lose.SetActive(true);
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
        if (player2 == 0)
        {
            rock2.SetActive(true);
            paper2.SetActive(false);
            scissor2.SetActive(false);
        }
        if (player2 == 1)
        {
            rock2.SetActive(false);
            paper2.SetActive(true);
            scissor2.SetActive(false);
        }
        if (player2 == 2)
        {
            rock2.SetActive(false);
            paper2.SetActive(false);
            scissor2.SetActive(true);
        }
    }

    public void Rock()
    {
        player1 = 0;
        RandomNmb();
        rock.SetActive(true);
        paper.SetActive(false);
        scissor.SetActive(false);
    }

    public void Paper()
    {
        player1 = 1; 
        RandomNmb();
        rock.SetActive(false);
        paper.SetActive(true);
        scissor.SetActive(false);
    }

    public void Scissor()
    {
        player1 = 2;
        RandomNmb();
        rock.SetActive(false);
        paper.SetActive(false);
        scissor.SetActive(true);
    }
}
