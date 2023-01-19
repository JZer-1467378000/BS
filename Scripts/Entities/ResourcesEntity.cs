using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity
{
    public class ResourcesEntity : EntityBase
    {
        public override void Interact()
        {
            if (Chart)
            {
                Chart.ExecuteBlock("FungusTest");
            }
        }
    }
}