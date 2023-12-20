using UnityEngine;

public class SuperCube : MonoBehaviour
{
    private float _speed = 0.001f;

    private void Update()
    {
        Run();
    }

    private void Run()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
        transform.Rotate(0, _speed, 0);
        transform.localScale += new Vector3(_speed, _speed, _speed);
    }
}
