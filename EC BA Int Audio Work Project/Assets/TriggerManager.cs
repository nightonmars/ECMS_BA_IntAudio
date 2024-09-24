using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public GameObject objectToReveal; // The third object to reveal
    private bool trigger1Activated = false;
    private bool trigger2Activated = false;

    // This function will be called from the trigger scripts
    public void TriggerActivated(int triggerID)
    {
        if (triggerID == 1)
        {
            trigger1Activated = true;
        }
        else if (triggerID == 2)
        {
            trigger2Activated = true;
        }

        // Check if both triggers are activated
        if (trigger1Activated && trigger2Activated)
        {
            RevealObject();
        }
    }

    // This function will reveal the third object
    private void RevealObject()
    {
        objectToReveal.SetActive(true);
    }
}
