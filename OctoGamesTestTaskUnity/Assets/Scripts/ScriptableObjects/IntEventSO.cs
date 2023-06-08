using System;
using UnityEngine;

namespace QulisoftTestTask.ScriptableObjects
{
    [CreateAssetMenu(fileName = "IntEventSO", menuName = "ScriptableObjects/IntEventSO", order = 0)]
    public class IntEventSO : ScriptableObject
    {
        public event Action<int> OnValueChanged;

        public void ChangeValue(int value)
        {
            OnValueChanged?.Invoke(value);
        }
    }
}