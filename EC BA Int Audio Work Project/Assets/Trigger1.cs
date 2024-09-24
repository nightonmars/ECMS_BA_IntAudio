using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public TriggerManager triggerManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the player has the tag "Player"
        {
            triggerManager.TriggerActivated(1); // Notify the manager that Trigger 1 was activated
        }
    }
}
