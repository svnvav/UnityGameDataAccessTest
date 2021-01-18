using UnityEngine;

namespace Plarium.VGO.Practice
{
    public class UpdateTestSO : MonoBehaviour
    {
        public GameDataSO _gameData;
        private bool _dummy;

        private void Update()
        {
            for (int i = 0; i < UpdateTestHandler.IterationsPerFrame; ++i)
            {
                _dummy = _gameData.Flag;
            }
        }
    }
}