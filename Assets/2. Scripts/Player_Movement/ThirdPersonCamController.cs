using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public Transform player; // Assign the player transform in the Inspector
    public float distance = 5f; // Distance from the player
    public float height = 3f; // Height above the player
    public float rotationDamping = 3f; // Rotation damping
    public float heightDamping = 2f; // Height damping

    private void Start()
    {
        if (player == null)
        {
            Debug.LogWarning("Player transform is not assigned in the Inspector.");
        }
    }

    void LateUpdate()
    {
        if (!player) return;

        // Calculate the desired position
        float wantedRotationAngle = player.eulerAngles.y;
        float wantedHeight = player.position.y + height;
        float currentRotationAngle = transform.eulerAngles.y;
        float currentHeight = transform.position.y;

        // Smoothly rotate towards the desired angle
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
        // Smoothly adjust height
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        // Calculate the position
        Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
        Vector3 position = player.position;
        position -= currentRotation * Vector3.forward * distance;
        position.y = currentHeight;

        // Apply the position and rotation
        transform.position = position;
        transform.LookAt(player);
    }

    // Optional: To visualize the camera distance and height in the editor
    private void OnDrawGizmosSelected()
    {
        if (player)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(player.position, player.position + Vector3.up * height);
            Gizmos.DrawWireSphere(player.position + Vector3.up * height, 0.1f);
        }
    }
}
