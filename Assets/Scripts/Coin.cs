using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 200.0f;

    void Update()
    {
        // Rotation
        float angle = _rotationSpeed * Time.deltaTime;
        transform.Rotate(angle, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Отправка сообщения, подсчет монет
            Destroy(gameObject);
        }
    }
}
