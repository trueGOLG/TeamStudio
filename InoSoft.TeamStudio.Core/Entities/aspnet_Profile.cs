//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace InoSoft.TeamStudio.Core.Entities
{
    public partial class aspnet_Profile
    {
        #region Primitive Properties
    
        public virtual System.Guid UserId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    if (aspnet_Users != null && aspnet_Users.UserId != value)
                    {
                        aspnet_Users = null;
                    }
                    _userId = value;
                }
            }
        }
        private System.Guid _userId;
    
        public virtual string PropertyNames
        {
            get;
            set;
        }
    
        public virtual string PropertyValuesString
        {
            get;
            set;
        }
    
        public virtual byte[] PropertyValuesBinary
        {
            get;
            set;
        }
    
        public virtual System.DateTime LastUpdatedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual aspnet_Users aspnet_Users
        {
            get { return _aspnet_Users; }
            set
            {
                if (!ReferenceEquals(_aspnet_Users, value))
                {
                    var previousValue = _aspnet_Users;
                    _aspnet_Users = value;
                    Fixupaspnet_Users(previousValue);
                }
            }
        }
        private aspnet_Users _aspnet_Users;

        #endregion
        #region Association Fixup
    
        private void Fixupaspnet_Users(aspnet_Users previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.aspnet_Profile, this))
            {
                previousValue.aspnet_Profile = null;
            }
    
            if (aspnet_Users != null)
            {
                aspnet_Users.aspnet_Profile = this;
                if (UserId != aspnet_Users.UserId)
                {
                    UserId = aspnet_Users.UserId;
                }
            }
        }

        #endregion
    }
}