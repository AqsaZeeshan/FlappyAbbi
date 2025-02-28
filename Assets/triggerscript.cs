using UnityEngine;

public class triggerscript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision is with a closed pipe
        var closedPipeScript = collision.GetComponentInParent<ClosedPipeScript>();
        if (closedPipeScript != null)
        {
            closedPipeScript.OpenPipe();
            Debug.Log("ClosedpipeMove called for: " + collision.gameObject.name);
        }
        else
        {
            Debug.LogError("ClosedPipeScript not found on the parent of the collided object.");
        }
    }
}
