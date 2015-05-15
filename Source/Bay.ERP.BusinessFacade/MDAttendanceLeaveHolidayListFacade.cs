// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public sealed partial class MDAttendanceLeaveHolidayListFacade : IMDAttendanceLeaveHolidayListFacade
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

        public MDAttendanceLeaveHolidayListFacade()
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

        ~MDAttendanceLeaveHolidayListFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDAttendanceLeaveHolidayListFacade.Add(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().Add(mDAttendanceLeaveHolidayListEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAttendanceLeaveHolidayListFacade.Update(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().Update(mDAttendanceLeaveHolidayListEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAttendanceLeaveHolidayListFacade.Delete(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().Delete(mDAttendanceLeaveHolidayListEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDAttendanceLeaveHolidayListFacade.Add(IList<MDAttendanceLeaveHolidayListEntity> mDAttendanceLeaveHolidayListEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().Add(mDAttendanceLeaveHolidayListEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAttendanceLeaveHolidayListFacade.Update(IList<MDAttendanceLeaveHolidayListEntity> mDAttendanceLeaveHolidayListEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().Update(mDAttendanceLeaveHolidayListEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAttendanceLeaveHolidayListFacade.Delete(IList<MDAttendanceLeaveHolidayListEntity> mDAttendanceLeaveHolidayListEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().Delete(mDAttendanceLeaveHolidayListEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDAttendanceLeaveHolidayListEntity> IMDAttendanceLeaveHolidayListFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDAttendanceLeaveHolidayListFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDAttendanceLeaveHolidayListEntity IMDAttendanceLeaveHolidayListFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAttendanceLeaveHolidayListEntity.FLD_NAME_AttendanceLeaveHolidayListID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDAttendanceLeaveHolidayListDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
