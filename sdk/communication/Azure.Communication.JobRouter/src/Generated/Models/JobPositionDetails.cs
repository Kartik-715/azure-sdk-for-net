// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Dto for JobPositionDetails. </summary>
    public partial class JobPositionDetails
    {
        /// <summary> Initializes a new instance of JobPositionDetails. </summary>
        /// <param name="jobId"> Id of the job these details are about. </param>
        /// <param name="position"> Position of the job in question within that queue. </param>
        /// <param name="queueId"> Id of the queue this job is enqueued in. </param>
        /// <param name="queueLength"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimeMinutes"> Estimated wait time of the job rounded up to the nearest minute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="queueId"/> is null. </exception>
        internal JobPositionDetails(string jobId, int position, string queueId, int queueLength, double estimatedWaitTimeMinutes)
        {
            Argument.AssertNotNull(jobId, nameof(jobId));
            Argument.AssertNotNull(queueId, nameof(queueId));

            JobId = jobId;
            Position = position;
            QueueId = queueId;
            QueueLength = queueLength;
            EstimatedWaitTimeMinutes = estimatedWaitTimeMinutes;
        }

        /// <summary> Id of the job these details are about. </summary>
        public string JobId { get; }
        /// <summary> Position of the job in question within that queue. </summary>
        public int Position { get; }
        /// <summary> Id of the queue this job is enqueued in. </summary>
        public string QueueId { get; }
        /// <summary> Length of the queue: total number of enqueued jobs. </summary>
        public int QueueLength { get; }
        /// <summary> Estimated wait time of the job rounded up to the nearest minute. </summary>
        public double EstimatedWaitTimeMinutes { get; }
    }
}
