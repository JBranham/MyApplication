﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyApplication
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyApplicationRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("e83e8ad1-7036-4c5a-a0d4-e7a8c414c27f")]
    public partial class MyApplicationRepository : RepoGenBaseFolder
    {
        static MyApplicationRepository instance = new MyApplicationRepository();

        /// <summary>
        /// Gets the singleton class instance representing the MyApplicationRepository element repository.
        /// </summary>
        [RepositoryFolder("e83e8ad1-7036-4c5a-a0d4-e7a8c414c27f")]
        public static MyApplicationRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyApplicationRepository() 
            : base("MyApplicationRepository", "/", null, 0, false, "e83e8ad1-7036-4c5a-a0d4-e7a8c414c27f", ".\\RepositoryImages\\MyApplicationRepositorye83e8ad1.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e83e8ad1-7036-4c5a-a0d4-e7a8c414c27f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class MyApplicationRepositoryFolders
    {
    }
#pragma warning restore 0436
}