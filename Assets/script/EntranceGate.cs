using UnityEngine;
using TMPro;

public class EntranceGate : MonoBehaviour
{
    public Transform gate;
    public GameObject ticketPanel;
    public TextMeshProUGUI ticketText;

    public float openHeight = 3f;
    public float openSpeed = 2f;

    bool playerNear = false;
    bool gateOpened = false;

    Vector3 closedPosition;
    Vector3 openPosition;

    void Start()
    {
        closedPosition = gate.position;
        openPosition = closedPosition + Vector3.up * openHeight;
    }

    void Update()
    {
        if (playerNear)
        {
            ticketPanel.SetActive(true);

            if (TicketManager.instance.hasTicket)
            {
                ticketText.text = "Gate Opened";

                gateOpened = true;
            }
            else
            {
                ticketText.text = "Please Buy Ticket First";
            }
        }

        if (gateOpened)
        {
            gate.position = Vector3.Lerp(
                gate.position,
                openPosition,
                Time.deltaTime * openSpeed
            );
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