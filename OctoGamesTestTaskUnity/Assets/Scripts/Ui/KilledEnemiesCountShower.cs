using TMPro;
using UnityEngine;

namespace QulisoftTestTask.Ui
{
    public class KilledEnemiesCountShower : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _score;
        
        public void UpdateValue(int value)
        {
            _score.text = value.ToString();
        }
    }
}