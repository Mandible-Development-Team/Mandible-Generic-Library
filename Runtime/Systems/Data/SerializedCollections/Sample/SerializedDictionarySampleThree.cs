using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mandible.Systems.Data
{
    public class SerializedDictionarySampleThree : MonoBehaviour
    {
        [SerializeField]
        private SerializedDictionary<ScriptableObject, string> _nameOverrides;
    }
}