using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity
{
    public class EventEntity : EntityBase
    {
        public string ChartBlockName;
        public List<string> ItemIDs;

        public void GainItems()
        {
            if (ItemIDs.Count != 0)
            {
            }
        }

        public override void Interact()
        {
            if (Chart)
            {
                var block = Chart.FindBlock(ChartBlockName);
                //block.Execute();

                Chart.ExecuteBlock(block);
            }
        }
    }
}