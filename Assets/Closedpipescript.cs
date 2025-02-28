using UnityEngine;

public class ClosedPipeScript : MonoBehaviour
{
    public float heightOffset = 10f;

    public void OpenPipe()
    {
        var top = transform.Find("Top Pipe")?.gameObject;
        var middle = transform.Find("Middle")?.gameObject;
        var bottom = transform.Find("bottom pipe")?.gameObject;

        if (top != null && bottom != null)
        {
            top.transform.position += new Vector3(0, heightOffset, 0);
            bottom.transform.position -= new Vector3(0, heightOffset, 0);
            Debug.Log("Moved top pipe to: " + top.transform.position);
            Debug.Log("Moved bottom pipe to: " + bottom.transform.position);
        }
        else
        {
            Debug.LogWarning("Top or Bottom pipe not found.");
        }

        if (middle != null)
        {
            middle.SetActive(true);
            Debug.Log("Activated middle pipe");
        }
        else
        {
            Debug.LogWarning("Middle pipe not found or not set active");
        }
    }
}

