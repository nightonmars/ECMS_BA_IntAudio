using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public TriggerManager triggerManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the player has the tag "Player"
        {
            triggerManager.TriggerActivated(2); // Notify the manager that Trigger 2 was activated
        }
    }
}
