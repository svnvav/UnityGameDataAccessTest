using UnityEngine;

namespace Plarium.VGO.Practice
{
    public class UpdateTestField : MonoBehaviour
    {
        [SerializeField] private bool _flag;
        private bool _dummy;

        private void Update()
        {
            for (int i = 0; i < UpdateTestHandler.IterationsPerFrame; ++i)
            {
                _dummy = _flag;
            }
        }
    }
}