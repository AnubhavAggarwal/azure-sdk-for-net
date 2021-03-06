// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// All Operations related to Device Jobs
    /// </summary>
    public partial interface IDeviceJobOperations
    {
        /// <summary>
        /// Begin async task to update a device job.
        /// </summary>
        /// <param name='deviceId'>
        /// id of device
        /// </param>
        /// <param name='jobId'>
        /// id of job to update
        /// </param>
        /// <param name='updateRequest'>
        /// Request data, contains the action to be taken
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        Task<GuidTaskResponse> BeginUpdateDeviceJobAsync(string deviceId, string jobId, UpdateDeviceJobRequest updateRequest, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <param name='deviceId'>
        /// Device id of device of jobs
        /// </param>
        /// <param name='jobType'>
        /// Type of deviceJob
        /// </param>
        /// <param name='jobStatus'>
        /// Status of job
        /// </param>
        /// <param name='jobId'>
        /// Id of job
        /// </param>
        /// <param name='startTime'>
        /// Job start time, in ISO 8601 format 'yyyy'-'MM'-'dd'T'HH':'mm':'ss'
        /// </param>
        /// <param name='endTime'>
        /// Job end time, in ISO 8601 format 'yyyy'-'MM'-'dd'T'HH':'mm':'ss'
        /// </param>
        /// <param name='skip'>
        /// Pagination parameter. The number of entries to skip, i.e. index of
        /// the first entry to be returned
        /// </param>
        /// <param name='top'>
        /// Pagination parameter. The number of entries to return after
        /// skipping the 'skip' number of entries
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response model of Get Query for a Device Job
        /// </returns>
        Task<GetDeviceJobResponse> GetAsync(string deviceId, string jobType, string jobStatus, string jobId, string startTime, string endTime, int skip, int top, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update a device job
        /// </summary>
        /// <param name='deviceId'>
        /// id of device
        /// </param>
        /// <param name='jobId'>
        /// id of job to update
        /// </param>
        /// <param name='updateRequest'>
        /// Request data, contains the action to be taken
        /// </param>
        /// <param name='customRequestHeaders'>
        /// The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        Task<TaskStatusInfo> UpdateDeviceJobAsync(string deviceId, string jobId, UpdateDeviceJobRequest updateRequest, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
