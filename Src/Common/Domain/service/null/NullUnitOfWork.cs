﻿namespace Ttu.Domain
{
    public class NullUnitOfWork : IUnitOfWork
    {

        public static IUnitOfWork Singleton = new NullUnitOfWork();

        #region Constructors

        protected NullUnitOfWork()
        {
        }

        #endregion

        #region Properties

        public virtual string SessionId { get; set; }
        public virtual IUser User { get; set; }

        public virtual IUnitOfWorkRepository<IContact> Contacts { get { return CreateUowRepository<IContact>(); } }
        public virtual IUnitOfWorkRepository<IOrganization> Organizations { get { return CreateUowRepository<IOrganization>(); } }
        public virtual IUnitOfWorkRepository<IOrganizationUser> OrganizationUsers { get { return CreateUowRepository<IOrganizationUser>(); } }
        public virtual IUnitOfWorkRepository<IProject> Projects { get { return CreateUowRepository<IProject>(); } }
        public virtual IUnitOfWorkRepository<IRecommendation> Recommendations { get { return CreateUowRepository<IRecommendation>(); } }
        public virtual IUnitOfWorkRepository<IUser> Users { get { return CreateUowRepository<IUser>(); } }
        public virtual IUnitOfWorkRepository<IProjectApplication> ProjectApplications { get { return CreateUowRepository<IProjectApplication>(); } }
        public virtual IUnitOfWorkRepository<IVolunteerProfileReview> VolunteerProfileReviews { get { return CreateUowRepository<IVolunteerProfileReview>(); } }
        public virtual IUnitOfWorkRepository<IVolunteerProfile> VolunteerProfiles { get { return CreateUowRepository<IVolunteerProfile>(); } }

        #endregion

        #region Public Methods

        public virtual void Abort()
        {
            // do nothing
        }

        public virtual void Commit()
        {
            // do nothing
        }

        public virtual void Release()
        {
            // do nothing
        }

        public virtual void Reset()
        {
            // do nothing
        }

        #endregion

        #region Helper Methods

        private IUnitOfWorkRepository<T> CreateUowRepository<T>() where T : class
        {
            return NullUnitOfWorkRepository<T>.Singleton;
        }

        #endregion

    }
}
