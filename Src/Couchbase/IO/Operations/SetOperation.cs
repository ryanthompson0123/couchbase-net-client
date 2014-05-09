﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couchbase.Core;

namespace Couchbase.IO.Operations
{
    /// <summary>
    /// Add a key to the database, replacing the key if it already exists.
    /// </summary>
    /// <typeparam name="T">The value to insert.</typeparam>
    internal sealed class SetOperation<T> : OperationBase<T>
    {
        public SetOperation(string key, T value, IVBucket vBucket)
            : base(key, value, vBucket)
        {
        }

        public override OperationCode OperationCode
        {
            get { return OperationCode.Set; }
        }
    }
}
