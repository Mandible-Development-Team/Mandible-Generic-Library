using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using Mandible.Systems.Data;

namespace Mandible.Systems.Data
{
    public class FiniteStateMachine : MonoBehaviour { }

    [System.Serializable]
    public class FiniteState
    {
        [SerializeField] public string name = "New State";
        [SerializeField] UnityEvent stateEvent = new UnityEvent();

        public FiniteState(string name = "New State", UnityEvent newEvent = default)
        {
            this.name = name;
            this.stateEvent = newEvent;
        }

        public void OnEventUpdate()
        {
            stateEvent?.Invoke();
        }
    }
}


