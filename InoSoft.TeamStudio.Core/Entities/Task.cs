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
    public partial class Task
    {
        #region Primitive Properties
    
        public virtual int TaskId
        {
            get;
            set;
        }
    
        public virtual Nullable<int> ParentTaskId
        {
            get { return _parentTaskId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_parentTaskId != value)
                    {
                        if (Task1 != null && Task1.TaskId != value)
                        {
                            Task1 = null;
                        }
                        _parentTaskId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _parentTaskId;
    
        public virtual int ProjectId
        {
            get;
            set;
        }
    
        public virtual int AssigneeId
        {
            get { return _assigneeId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_assigneeId != value)
                    {
                        if (Project != null && Project.ProjectId != value)
                        {
                            Project = null;
                        }
                        if (User != null && User.UserId != value)
                        {
                            User = null;
                        }
                        _assigneeId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private int _assigneeId;
    
        public virtual Nullable<int> VersionId
        {
            get { return _versionId; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_versionId != value)
                    {
                        if (Version != null && Version.VersionId != value)
                        {
                            Version = null;
                        }
                        _versionId = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _versionId;
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Project Project
        {
            get { return _project; }
            set
            {
                if (!ReferenceEquals(_project, value))
                {
                    var previousValue = _project;
                    _project = value;
                    FixupProject(previousValue);
                }
            }
        }
        private Project _project;
    
        public virtual ICollection<Task> Tasks1
        {
            get
            {
                if (_tasks1 == null)
                {
                    var newCollection = new FixupCollection<Task>();
                    newCollection.CollectionChanged += FixupTasks1;
                    _tasks1 = newCollection;
                }
                return _tasks1;
            }
            set
            {
                if (!ReferenceEquals(_tasks1, value))
                {
                    var previousValue = _tasks1 as FixupCollection<Task>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupTasks1;
                    }
                    _tasks1 = value;
                    var newValue = value as FixupCollection<Task>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupTasks1;
                    }
                }
            }
        }
        private ICollection<Task> _tasks1;
    
        public virtual Task Task1
        {
            get { return _task1; }
            set
            {
                if (!ReferenceEquals(_task1, value))
                {
                    var previousValue = _task1;
                    _task1 = value;
                    FixupTask1(previousValue);
                }
            }
        }
        private Task _task1;
    
        public virtual User User
        {
            get { return _user; }
            set
            {
                if (!ReferenceEquals(_user, value))
                {
                    var previousValue = _user;
                    _user = value;
                    FixupUser(previousValue);
                }
            }
        }
        private User _user;
    
        public virtual Version Version
        {
            get { return _version; }
            set
            {
                if (!ReferenceEquals(_version, value))
                {
                    var previousValue = _version;
                    _version = value;
                    FixupVersion(previousValue);
                }
            }
        }
        private Version _version;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupProject(Project previousValue)
        {
            if (previousValue != null && previousValue.Tasks.Contains(this))
            {
                previousValue.Tasks.Remove(this);
            }
    
            if (Project != null)
            {
                if (!Project.Tasks.Contains(this))
                {
                    Project.Tasks.Add(this);
                }
                if (AssigneeId != Project.ProjectId)
                {
                    AssigneeId = Project.ProjectId;
                }
            }
        }
    
        private void FixupTask1(Task previousValue)
        {
            if (previousValue != null && previousValue.Tasks1.Contains(this))
            {
                previousValue.Tasks1.Remove(this);
            }
    
            if (Task1 != null)
            {
                if (!Task1.Tasks1.Contains(this))
                {
                    Task1.Tasks1.Add(this);
                }
                if (ParentTaskId != Task1.TaskId)
                {
                    ParentTaskId = Task1.TaskId;
                }
            }
            else if (!_settingFK)
            {
                ParentTaskId = null;
            }
        }
    
        private void FixupUser(User previousValue)
        {
            if (previousValue != null && previousValue.Tasks.Contains(this))
            {
                previousValue.Tasks.Remove(this);
            }
    
            if (User != null)
            {
                if (!User.Tasks.Contains(this))
                {
                    User.Tasks.Add(this);
                }
                if (AssigneeId != User.UserId)
                {
                    AssigneeId = User.UserId;
                }
            }
        }
    
        private void FixupVersion(Version previousValue)
        {
            if (previousValue != null && previousValue.Tasks.Contains(this))
            {
                previousValue.Tasks.Remove(this);
            }
    
            if (Version != null)
            {
                if (!Version.Tasks.Contains(this))
                {
                    Version.Tasks.Add(this);
                }
                if (VersionId != Version.VersionId)
                {
                    VersionId = Version.VersionId;
                }
            }
            else if (!_settingFK)
            {
                VersionId = null;
            }
        }
    
        private void FixupTasks1(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Task item in e.NewItems)
                {
                    item.Task1 = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Task item in e.OldItems)
                {
                    if (ReferenceEquals(item.Task1, this))
                    {
                        item.Task1 = null;
                    }
                }
            }
        }

        #endregion
    }
}
