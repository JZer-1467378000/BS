using Fungus;
using UnityEngine;

namespace Entity
{
    public abstract class EntityBase : MonoBehaviour
    {
        public Flowchart Chart;

        public void Awake()
        {
            Chart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        }

        public abstract void Interact();
    }
}