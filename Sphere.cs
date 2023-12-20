using UnityEngine;

public class Sphere : MonoBehaviour
{
    private float _speed = 1;

    private void Update()
    {
        Run();
    }

    private void Run()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }
}
