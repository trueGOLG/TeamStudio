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
    public partial class User
    {
        #region Primitive Properties
    
        public virtual int UserId
        {
            get;
            set;
        }
    
        public virtual string FirstName
        {
            get;
            set;
        }
    
        public virtual string LastName
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual string UserName
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Project> Projects
        {
            get
            {
                if (_projects == null)
                {
                    var newCollection = new FixupCollection<Project>();
                    newCollection.CollectionChanged += FixupProjects;
                    _projects = newCollection;
                }
                return _projects;
            }
            set
            {
                if (!ReferenceEquals(_projects, value))
                {
                    var previousValue = _projects as FixupCollection<Project>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupProjects;
                    }
                    _projects = value;
                    var newValue = value as FixupCollection<Project>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupProjects;
                    }
                }
            }
        }
        private ICollection<Project> _projects;
    
        public virtual ICollection<Task> Tasks
        {
            get
            {
                if (_tasks == null)
                {
                    var newCollection = new FixupCollection<Task>();
                    newCollection.CollectionChanged += FixupTasks;
                    _tasks = newCollection;
                }
                return _tasks;
            }
            set
            {
                if (!ReferenceEquals(_tasks, value))
                {
                    var previousValue = _tasks as FixupCollection<Task>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupTasks;
                    }
                    _tasks = value;
                    var newValue = value as FixupCollection<Task>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupTasks;
                    }
                }
            }
        }
        private ICollection<Task> _tasks;
    
        public virtual ICollection<Team> Teams
        {
            get
            {
                if (_teams == null)
                {
                    var newCollection = new FixupCollection<Team>();
                    newCollection.CollectionChanged += FixupTeams;
                    _teams = newCollection;
                }
                return _teams;
            }
            set
            {
                if (!ReferenceEquals(_teams, value))
                {
                    var previousValue = _teams as FixupCollection<Team>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupTeams;
                    }
                    _teams = value;
                    var newValue = value as FixupCollection<Team>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupTeams;
                    }
                }
            }
        }
        private ICollection<Team> _teams;

        #endregion
        #region Association Fixup
    
        private void FixupProjects(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Project item in e.NewItems)
                {
                    item.User = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Project item in e.OldItems)
                {
                    if (ReferenceEquals(item.User, this))
                    {
                        item.User = null;
                    }
                }
            }
        }
    
        private void FixupTasks(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Task item in e.NewItems)
                {
                    item.User = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Task item in e.OldItems)
                {
                    if (ReferenceEquals(item.User, this))
                    {
                        item.User = null;
                    }
                }
            }
        }
    
        private void FixupTeams(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Team item in e.NewItems)
                {
                    if (!item.Users.Contains(this))
                    {
                        item.Users.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Team item in e.OldItems)
                {
                    if (item.Users.Contains(this))
                    {
                        item.Users.Remove(this);
                    }
                }
            }
        }

        #endregion
    }
}