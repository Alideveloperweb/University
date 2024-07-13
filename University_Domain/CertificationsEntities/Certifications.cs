using University_Common.Domain;
using University_Domain.Associations;

namespace University_Domain.CertificationsEntities
{
    public class Certifications : EntityBase<int>
    {
        #region Properties

        /// <summary>
        /// نام 
        /// </summary>
        public string Name { get; set; }


        #endregion

        #region Create

        public Certifications(string Name) => this.Name = Name;

        #endregion

        #region Edit

        public void Edit(string Name)
        {
            this.Name = Name;
        }

        #endregion

        #region Remove

        public void Remove()
        {
            this.IsRemove = true;
        }

        #endregion

        #region Restore

        public void Restore()
        {
            this.IsRemove = false;
        }

        #endregion

        #region Relation

        public ICollection<CertificationsEmployee> CertificationsEmployees { get; set; }

        #endregion
    }
}
