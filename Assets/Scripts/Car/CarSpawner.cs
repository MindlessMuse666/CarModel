using UnityEngine;

namespace Car
{
    public class CarSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        private void Awake()
        {
            Instantiate(_prefab);
        }
    }
}
