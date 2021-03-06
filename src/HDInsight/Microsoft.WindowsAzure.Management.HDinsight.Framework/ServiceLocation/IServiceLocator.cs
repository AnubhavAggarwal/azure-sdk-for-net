// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.
namespace Microsoft.WindowsAzure.Management.HDInsight.Framework.ServiceLocation
{
    using System;

    /// <summary>
    ///     Locates services that ViewModels need.
    /// </summary>
    internal interface IServiceLocator
    {
        /// <summary>
        ///     Locates an instance that implements the specified interface.
        /// </summary>
        /// <typeparam name="T"> Interface to locate. </typeparam>
        /// <returns> Instance of the interface. </returns>
        T Locate<T>();

        /// <summary>
        ///     Locates an instance that implements the specified interface.
        /// </summary>
        /// <param name="type"> Interface to locate. </param>
        /// <returns> Instance of the interface. </returns>
        object Locate(Type type);
    }
}