using UnityEngine;

public class TicketManager : MonoBehaviour
{
    public static TicketManager instance;

    public bool hasTicket = false;

    void Awake()
    {
        instance = this;
    }
}