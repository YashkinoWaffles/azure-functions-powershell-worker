//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.Azure.Functions.PowerShellWorker.Utility;
using LogLevel = Microsoft.Azure.WebJobs.Script.Grpc.Messages.RpcLog.Types.Level;

namespace Microsoft.Azure.Functions.PowerShellWorker.PowerShell
{
    using System.Management.Automation;

    internal class StreamHandler
    {
        RpcLogger _logger;

        public StreamHandler(RpcLogger logger)
        {
            _logger = logger;
        }

        public void DebugDataAdding(object sender, DataAddingEventArgs e)
        {
            if(e.ItemAdded is DebugRecord record)
            {
                _logger.Log(LogLevel.Debug, $"DEBUG: {record.Message}");
            }
        }

        public void ErrorDataAdding(object sender, DataAddingEventArgs e)
        {
            if(e.ItemAdded is ErrorRecord record)
            {
                _logger.Log(LogLevel.Error, $"ERROR: {record.Exception.Message}", record.Exception);
            }
        }

        public void InformationDataAdding(object sender, DataAddingEventArgs e)
        {
            if(e.ItemAdded is InformationRecord record)
            {
                _logger.Log(LogLevel.Information, $"INFORMATION: {record.MessageData}");
            }
        }

        public void ProgressDataAdding(object sender, DataAddingEventArgs e)
        {
            if(e.ItemAdded is ProgressRecord record)
            {
                _logger.Log(LogLevel.Trace, $"PROGRESS: {record.StatusDescription}");
            }
        }

        public void VerboseDataAdding(object sender, DataAddingEventArgs e)
        {
            if(e.ItemAdded is VerboseRecord record)
            {
                _logger.Log(LogLevel.Trace, $"VERBOSE: {record.Message}");
            }
        }

        public void WarningDataAdding(object sender, DataAddingEventArgs e)
        {
            if(e.ItemAdded is WarningRecord record)
            {
                _logger.Log(LogLevel.Warning, $"WARNING: {record.Message}");
            }
        }
    }
}
