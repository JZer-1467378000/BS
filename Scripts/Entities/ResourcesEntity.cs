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