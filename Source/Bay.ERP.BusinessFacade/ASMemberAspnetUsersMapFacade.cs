// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




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
    public sealed partial class ASMemberAspnetUsersMapFacade : IASMemberAspnetUsersMapFacade
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

        public ASMemberAspnetUsersMapFacade()
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

        ~ASMemberAspnetUsersMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IASMemberAspnetUsersMapFacade.Add(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().Add(aSMemberAspnetUsersMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IASMemberAspnetUsersMapFacade.Update(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().Update(aSMemberAspnetUsersMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IASMemberAspnetUsersMapFacade.Delete(ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().Delete(aSMemberAspnetUsersMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IASMemberAspnetUsersMapFacade.Add(IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().Add(aSMemberAspnetUsersMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASMemberAspnetUsersMapFacade.Update(IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().Update(aSMemberAspnetUsersMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASMemberAspnetUsersMapFacade.Delete(IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().Delete(aSMemberAspnetUsersMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ASMemberAspnetUsersMapEntity> IASMemberAspnetUsersMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IASMemberAspnetUsersMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ASMemberAspnetUsersMapEntity IASMemberAspnetUsersMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ASMemberAspnetUsersMapEntity.FLD_NAME_ASMemberAspnetUsersMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateASMemberAspnetUsersMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
