using UnityEngine;
using TMPro;

public class TrophyInteraction : MonoBehaviour
{
    public GameObject trophyPanel;
    public TextMeshProUGUI trophyText;

    [TextArea]
    public string trophyInfo;

    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            trophyPanel.SetActive(true);
            trophyText.text = trophyInfo;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            trophyPanel.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            trophyPanel.SetActive(false);
        }
    }
}