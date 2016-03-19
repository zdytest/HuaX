using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DLG.Framework.Utility;

namespace DLG.Account.Contract
{
    public enum EnumBusinessPermission
    {
        [EnumTitle("[无]", IsDisplay = false)]
        None = 0,
        /// <summary>
        /// 管理用户
        /// </summary>
        [EnumTitle("管理用户")]
        AccountManage_User = 101,

        /// <summary>
        /// 管理角色
        /// </summary>
        [EnumTitle("管理角色")]
        AccountManage_Role = 102,



        
        [EnumTitle("需求发布管理")]
        HRManage_XQRecord = 301,
        [EnumTitle("入职管理")]
        HRManage_RZRecord = 302,
        [EnumTitle("离职管理")]
        HRManage_LZRecord = 303,

        //[EnumTitle("教育培训模块")]
        //HRManage_JYRecord = 401,


        //[EnumTitle("薪酬绩效模块")]
        //HRManage_XCRecord = 501,


        //[EnumTitle("招聘部")]
        //HRManage_ZPRecord = 601,







        [EnumTitle("CRM管理来访来电")]
        CrmManage_VisitRecord = 801,

        [EnumTitle("CRM客户管理")]
        CrmManage_Customer = 802,

        [EnumTitle("CRM项目管理")]
        CrmManage_Project = 803,

        [EnumTitle("CRM查看统计信息")]
        CrmManage_Analysis = 804,


        [EnumTitle("HR管理员工")]
        HRManage_Staff = 901,

        [EnumTitle("HR管理部门")]
        HRManage_Branch = 902,

        [EnumTitle("组织结构管理")]
        HRManage_Org = 903,
    }
}
