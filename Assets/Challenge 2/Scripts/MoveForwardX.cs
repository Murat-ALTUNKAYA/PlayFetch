using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
