
using UnityEngine;

namespace Plarium.VGO.Practice
{
    public class UpdateTestHandler : MonoBehaviour
    {
        public static int IterationsPerFrame = 5000000;

        public MonoBehaviour[] _updateTests;

        public void SetActiveTest(int index)
        {
            for (int i = 0; i < _updateTests.Length; i++)
            {
                _updateTests[i].enabled = i == index;
            }
        }

    }
}