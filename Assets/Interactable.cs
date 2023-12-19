using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 100f;

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
