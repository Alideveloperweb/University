using System;
using University_Common.Domain;
using University_Domain.Associations;

namespace University_Domain.RecentProjectsEntities
{
    public class RecentProjects : EntityBase<int>
    {
        #region Properties

        /// <summary>
        /// نام 
        /// </summary>
        public string Name { get; set; }


        #endregion

        #region Create

        public RecentProjects(string Name) => this.Name = Name;

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

        public ICollection<RecentProjectsEmployee> RecentProjectsEmployee { get; set; }

        #endregion
    }
}
