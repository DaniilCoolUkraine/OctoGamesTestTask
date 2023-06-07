using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Ui
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] private IntEventSO _onCounterValueChanged;
        [SerializeField] private EventSO _onPlayerDeath;

        [SerializeField] private KilledEnemiesCountShower _killedEnemiesCountShower;
        [SerializeField] private ScreenController[] _screenControllers;

        private void OnEnable()
        {
            _onCounterValueChanged.OnValueChanged += _killedEnemiesCountShower.UpdateValue;
            foreach (ScreenController screenController in _screenControllers)
            {
                _onPlayerDeath.OnInvoked += screenController.SwitchScreen;
            }
        }

        private void OnDisable()
        {
            _onCounterValueChanged.OnValueChanged -= _killedEnemiesCountShower.UpdateValue;
            foreach (ScreenController screenController in _screenControllers)
            {
                _onPlayerDeath.OnInvoked -= screenController.SwitchScreen;
            }
        }
    }
}