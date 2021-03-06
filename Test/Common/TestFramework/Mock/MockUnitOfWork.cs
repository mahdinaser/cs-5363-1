﻿using Ttu.Domain;

namespace Ttu.TestFramework
{
    public class MockUnitOfWork : NullUnitOfWork
    {

        #region Constructors

        public MockUnitOfWork()
        {
            _Contacts = new MockUnitOfWorkRepository<IContact>();
            _Organizations = new MockUnitOfWorkRepository<IOrganization>();
            _Recommendations = new MockUnitOfWorkRepository<IRecommendation>();
            _Users = new MockUnitOfWorkRepository<IUser>();
        }

        #endregion

        #region Properties

        public override string SessionId { get; set; }
        public override IUser User { get; set; }
        public override IUnitOfWorkRepository<IContact> Contacts { get { return _Contacts; } }
        public override IUnitOfWorkRepository<IOrganization> Organizations { get { return _Organizations; } }
        public override IUnitOfWorkRepository<IRecommendation> Recommendations { get { return _Recommendations; } }
        public override IUnitOfWorkRepository<IUser> Users { get { return _Users; } }

        #endregion

        #region Variables

        private IUnitOfWorkRepository<IContact> _Contacts;
        private IUnitOfWorkRepository<IOrganization> _Organizations;
        private IUnitOfWorkRepository<IRecommendation> _Recommendations;
        private IUnitOfWorkRepository<IUser> _Users;

        #endregion

        #region Public Methods

        public override void Abort()
        {
        }

        public override void Commit()
        {
        }

        public override void Release()
        {
        }

        #endregion

    }
}
