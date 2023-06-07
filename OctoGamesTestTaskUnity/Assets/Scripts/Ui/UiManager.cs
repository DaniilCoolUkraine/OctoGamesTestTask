using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Ui
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] private IntEventSO _onCounterValueChanged;
        [SerializeField] private KilledEnemiesCountShower _killedEnemiesCountShower;

        private void OnEnable()
        {
            _onCounterValueChanged.OnValueChanged += _killedEnemiesCountShower.UpdateValue;
        }

        private void OnDisable()
        {
            _onCounterValueChanged.OnValueChanged -= _killedEnemiesCountShower.UpdateValue;
        }
    }
}