
namespace University_Common.Domain
{
    public class EntityBase<TKey>
    {
        public TKey Id { get;private set; }
        public string Name { get;private set; }
        public DateTime CreateDate { get;private set; }
        public DateTime LastUpdate { get; set; }
        public bool IsRemove { get; set; }
        public bool IsActive { get; set; }


        #region Constracture

        public EntityBase()
        {
            CreateDate = DateTime.Now;
            LastUpdate = DateTime.Now;

            IsRemove = false;
        }
        #endregion

    }
}
