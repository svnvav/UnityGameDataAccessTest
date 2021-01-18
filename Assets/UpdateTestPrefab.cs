using UnityEngine;

namespace Plarium.VGO.Practice
{
    public class UpdateTestPrefab : MonoBehaviour
    {
        public GameDataMonobeh _gameData;
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