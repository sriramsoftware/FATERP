using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bay.ERP.Common.Shared
{
    [Serializable()]
    public enum EmployeeDirectoryNodeType
    {
        [EnumDescription("Root Node")]
        RootNode = 1,

        [EnumDescription("Department Node")]
        DepartmentNode = 2,

        [EnumDescription("Sub Department Node")]
        SubDepartmentNode = 3,

        [EnumDescription("Job Title Node")]
        JobTitleNode = 4,

        [EnumDescription("Employee Node")]
        EmployeeNode = 5
    }

    [Serializable()]
    public enum TransactionRequired : int
    {
        [EnumDescription("Yes")]
        Yes = 1,

        [EnumDescription("No")]
        No = 2        
    }

    [Serializable()]
    public enum DatabaseOperationType : int
    {
        [EnumDescription("Add")]
        Add = 1,

        [EnumDescription("Update")]
        Update = 2,

        [EnumDescription("Delete")]
        Delete = 3,

        [EnumDescription("Load")]
        Load = 4,

        [EnumDescription("LoadWithFilterExpression")]
        LoadWithFilterExpression = 5,

        [EnumDescription("LoadWithSortExpression")]
        LoadWithSortExpression = 6,

        [EnumDescription("LoadWithFilterAndSortExpression")]
        LoadWithFilterAndSortExpression = 7,

        [EnumDescription("LoadPaged")]
        LoadPaged = 8,

        [EnumDescription("LoadPagedWithFilterExpression")]
        LoadPagedWithFilterExpression = 9,

        [EnumDescription("LoadPagedWithSortExpression")]
        LoadPagedWithSortExpression = 10,

        [EnumDescription("LoadPagedWithFilterAndSortExpression")]
        LoadPagedWithFilterAndSortExpression = 11
    }

    [Serializable()]
    public enum SQLJoinType : int
    {
        [EnumDescription("AND")]
        AND = 1,

        [EnumDescription("OR")]
        OR = 2
    }

    [Serializable()]
    public enum SQLMatchType : int
    {
        [EnumDescription("Equal")]
        Equal = 1,
        [EnumDescription("Like With Prefix Math")]
        LikeWithPrefixMath = 2,

        [EnumDescription("Like With Suffix Math")]
        LikeWithSuffixMath = 3,

        [EnumDescription("Like With Both Math")]
        LikeWithBothMath = 4,

        [EnumDescription("Is Null")]
        IsNull = 5
    }

    [Serializable()]
    public enum SQLSortOrderType : int
    {
        [EnumDescription("Assending")]
        Assending = 1,

        [EnumDescription("Decending")]
        Decending = 2,
        
        [EnumDescription("UnSpecified")]
        UnSpecified = 3
    }
}
