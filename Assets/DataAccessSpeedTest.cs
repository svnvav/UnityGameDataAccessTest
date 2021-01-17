
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace Plarium.VGO.Practice
{
    public class DataAccessSpeedTest : MonoBehaviour
    {
        public GameDataMonobeh _prefabGameData;
        public GameDataSO _soGameData;
        public int Iterations = 1000000;
        [SerializeField] private bool _flag;

        public Text _prefabTestLabel;
        public Text _soTestLabel;
        public Text _staticClassTestLabel;
        public Text _fieldTestLabel;

        
        private Stopwatch _stopwatch;

        private void Awake()
        {
            _stopwatch = new Stopwatch();
        }

        public void TestAll()
        {
            TestPrefab();
            TestSO();
            TestStaticClass();
            TestField();
        }

        public void TestPrefab()
        {
            _stopwatch.Reset();
            var dummy = false;
            _stopwatch.Start();
            for (int i = 0; i < Iterations; ++i)
            {
                dummy = _prefabGameData.Flag;
            }
            _stopwatch.Stop();
            _prefabTestLabel.text = _stopwatch.Elapsed.ToString();
        }

        public void TestSO()
        {
            _stopwatch.Reset();
            var dummy = false;
            _stopwatch.Start();
            for (int i = 0; i < Iterations; ++i)
            {
                dummy = _soGameData.Flag;
            }
            _stopwatch.Stop();
            _soTestLabel.text = _stopwatch.Elapsed.ToString();
        }

        public void TestStaticClass()
        {
            _stopwatch.Reset();
            var dummy = false;
            _stopwatch.Start();
            for (int i = 0; i < Iterations; ++i)
            {
                dummy = GameDataStaticClass.Flag;
            }
            _stopwatch.Stop();
            _staticClassTestLabel.text = _stopwatch.Elapsed.ToString();
        }
        
        public void TestField()
        {
            _stopwatch.Reset();
            var dummy = false;
            _stopwatch.Start();
            for (int i = 0; i < Iterations; ++i)
            {
                dummy = _flag;
            }
            _stopwatch.Stop();
            _fieldTestLabel.text = _stopwatch.Elapsed.ToString();
        }
    }
}
