using UnityEngine;

namespace Plarium.VGO.Practice
{
    public class UpdateTestStaticClass : MonoBehaviour
    {
        private bool _dummy;

        private void Update()
        {
            for (int i = 0; i < UpdateTestHandler.IterationsPerFrame; ++i)
            {
                _dummy = GameDataStaticClass.Flag;
            }
        }
    }
}