using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 range;
    void Start()
    {
        range = transform.position - player.position;
    }

    void Update()
    {
        transform.position = player.position + range;
    }
}
