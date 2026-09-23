using UnityEngine;

public class rotacao : MonoBehaviour
{
    [SerializeField] Vector3 rotationSpeed = new Vector3(0f, 45f, 0f);
    private float direction = 1f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            Debug.Log("A tela foi tocada!");
            direction *= -1f;
        }

        transform.Rotate(rotationSpeed * direction * Time.deltaTime);
    }
}
