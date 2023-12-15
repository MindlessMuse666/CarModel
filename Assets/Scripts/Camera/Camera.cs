using UnityEngine;

namespace Camera
{
    public class Camera : MonoBehaviour
    {
        [SerializeField] private Car.Car _car;
        [SerializeField] private Vector3 _offset;

        private void Start()
        {
            _car = FindObjectOfType<Car.Car>();
        }

        private void LateUpdate()
        {
            transform.position = _car.transform.position + _offset;
        }
    }
}