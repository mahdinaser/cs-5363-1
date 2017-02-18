﻿using Ttu.Domain;

namespace Ttu.Presentation
{
    public interface IPresenterFactory
    {

        // attributes
        IUnitOfWork UnitOfWork { get; }
        IUser User { get; }

        // behavior
        LogOnPresenter CreateLogOnPresenter();
        ManageUserPresenter CreateManageUserPresenter();

    }
}
