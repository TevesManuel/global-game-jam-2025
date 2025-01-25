using Unity.VisualScripting;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float velocity = 10.0f;

    void Update()
    {
        Vector2 direccion = (GameObject.Find("Player").GetComponent<Transform>().position - this.GetComponent<Transform>().position).normalized;
        this.GetComponent<Rigidbody2D>().linearVelocity = direccion * velocity;
    }
}
