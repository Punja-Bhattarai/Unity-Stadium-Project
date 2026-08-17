using UnityEngine;

public class GateInteraction : MonoBehaviour
{
    public GameObject leftGate;
    public GameObject rightGate;

    public GameObject interactUI;

    private bool opened = false;

    void Start()
    {
        interactUI.SetActive(false);
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 15f))
        {
            if (hit.collider.CompareTag("Gate") && !opened)
            {
                interactUI.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    OpenGate();
                }
            }
            else
            {
                interactUI.SetActive(false);
            }
        }
        else
        {
            interactUI.SetActive(false);
        }
    }

    void OpenGate()
    {
        opened = true;

        interactUI.SetActive(false);

        leftGate.transform.position += new Vector3(-8f, 0f, 0f);
        rightGate.transform.position += new Vector3(8f, 0f, 0f);
    }
}