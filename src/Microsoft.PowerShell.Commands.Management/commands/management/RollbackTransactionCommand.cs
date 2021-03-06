/********************************************************************++
Copyright (c) Microsoft Corporation.  All rights reserved.
--********************************************************************/

using System.Management.Automation;
using Dbg = System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
    /// <summary>
    /// A command that rolls back a transaction.
    /// </summary>
    [Cmdlet(VerbsCommon.Undo, "Transaction", SupportsShouldProcess = true, HelpUri = "http://go.microsoft.com/fwlink/?LinkID=135268")]
    public class UndoTransactionCommand : PSCmdlet
    {
        /// <summary>
        /// Rolls the current transaction back.
        /// </summary>
        protected override void EndProcessing()
        {
            // Rollback the transaction
            if (ShouldProcess(
                NavigationResources.TransactionResource,
                NavigationResources.RollbackAction))
            {
                this.Context.TransactionManager.Rollback();
            }
        }
    } // RollbackTransactionCommand
} // namespace Microsoft.PowerShell.Commands

