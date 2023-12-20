using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        IncreaseSize();
    }

    private void IncreaseSize()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed);
    }
}
