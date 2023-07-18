using UnityEngine;

public class Level4 : MonoBehaviour
{
    [SerializeField]
    public bool UseGravity = true;
    [SerializeField]
    private float _speed = 5;

    private void Update()
    {
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition; 
    }
}