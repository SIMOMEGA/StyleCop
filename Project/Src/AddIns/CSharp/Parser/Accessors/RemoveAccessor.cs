﻿//-----------------------------------------------------------------------
// <copyright file="RemoveAccessor.cs" company="Microsoft">
//   Copyright (c) Microsoft Corporation.
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
//-----------------------------------------------------------------------
namespace Microsoft.StyleCop.CSharp
{
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// Describes a remove accessor.
    /// </summary>
    public sealed class RemoveAccessor : Accessor
    {
        #region Internal Constructors

        /// <summary>
        /// Initializes a new instance of the RemoveAccessor class.
        /// </summary>
        /// <param name="proxy">Proxy object for the accessor.</param>
        /// <param name="unsafeCode">Indicates whether the element resides within a block of unsafe code.</param>
        internal RemoveAccessor(CodeUnitProxy proxy, bool unsafeCode)
            : base(proxy, "remove", AccessorType.Remove, unsafeCode)
        {
            Param.AssertNotNull(proxy, "proxy");
            Param.Ignore(unsafeCode);
        }

        #endregion Internal Constructors
    }
}