// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class MDProjectAssignedPersonTeamRoleFacade : IMDProjectAssignedPersonTeamRoleFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public MDProjectAssignedPersonTeamRoleFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~MDProjectAssignedPersonTeamRoleFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDProjectAssignedPersonTeamRoleFacade.Add(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().Add(mDProjectAssignedPersonTeamRoleEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectAssignedPersonTeamRoleFacade.Update(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().Update(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectAssignedPersonTeamRoleFacade.Delete(MDProjectAssignedPersonTeamRoleEntity mDProjectAssignedPersonTeamRoleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().Delete(mDProjectAssignedPersonTeamRoleEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDProjectAssignedPersonTeamRoleFacade.Add(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().Add(mDProjectAssignedPersonTeamRoleEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectAssignedPersonTeamRoleFacade.Update(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().Update(mDProjectAssignedPersonTeamRoleEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectAssignedPersonTeamRoleFacade.Delete(IList<MDProjectAssignedPersonTeamRoleEntity> mDProjectAssignedPersonTeamRoleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().Delete(mDProjectAssignedPersonTeamRoleEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDProjectAssignedPersonTeamRoleEntity> IMDProjectAssignedPersonTeamRoleFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDProjectAssignedPersonTeamRoleFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDProjectAssignedPersonTeamRoleEntity IMDProjectAssignedPersonTeamRoleFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectAssignedPersonTeamRoleEntity.FLD_NAME_ProjectAssignedPersonTeamRoleID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDProjectAssignedPersonTeamRoleDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
