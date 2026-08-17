using UnityEngine;
using TMPro;

public class TicketCounter : MonoBehaviour
{
    public GameObject ticketPanel;
    public TextMeshProUGUI ticketText;

    bool playerNear = false;
    bool ticketBought = false;

    void Update()
    {
        if (playerNear)
        {
            ticketPanel.SetActive(true);

            if (!ticketBought)
            {
                ticketText.text = "Press E To Buy Ticket";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    TicketManager.instance.hasTicket = true;

                    ticketBought = true;

                    ticketText.text = "Ticket Purchased Successfully";
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;

            ticketPanel.SetActive(false);
        }
    }
}

