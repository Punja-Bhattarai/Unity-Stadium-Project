using UnityEngine;

public class GateUITrigger : MonoBehaviour
{
    public GameObject interactUI;

    void Start()
    {
        interactUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactUI.SetActive(false);
        }
    }
}