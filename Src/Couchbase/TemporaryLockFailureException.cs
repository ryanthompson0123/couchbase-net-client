﻿using System;
using System.Runtime.Serialization;

namespace Couchbase
{
    /// <summary>
    /// Thrown when an attempt is made to lock on a document that has already been locked.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class TemporaryLockFailureException : Exception
    {
        public TemporaryLockFailureException()
        {
        }

        public TemporaryLockFailureException(string message) : base(message)
        {
        }

        public TemporaryLockFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }

#if NET45
        protected TemporaryLockFailureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2015 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion
