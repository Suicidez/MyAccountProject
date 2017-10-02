using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyAccount.Models.V_Models
{
    
    public class v_mstPermission
    {
        private string _PermissionDesc = "";
        private int _IsPermission = 0;
        public int IsPermission
        {
            get
            {
                return _IsPermission;
            }
            set
            {
                _IsPermission = value;
            }
         }

        public string PermissionDesc
        {
            get
            {
                if (_IsPermission == 1)
                {
                    _PermissionDesc = "Beginning";
                } else if (_IsPermission == 2)
                {
                    _PermissionDesc = "Standard";
                }
                else if (_IsPermission == 3)
                {
                    _PermissionDesc = "Advance";
                }
                return _PermissionDesc;
            }
        }
    }
}