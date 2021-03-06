﻿// Copyright (C) Pash Contributors. License: GPL/BSD. See https://github.com/Pash-Project/Pash/
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
    /// <summary>
    /// Parser instristics about executing a command.
    /// </summary>
    public class CommandInvocationIntrinsics
    {
        public string ExpandString(string source) { throw new NotImplementedException(); }
        public Collection<PSObject> InvokeScript(string script) { throw new NotImplementedException(); }
        public Collection<PSObject> InvokeScript(string script, bool useNewScope, PipelineResultTypes writeToPipeline, IList input, params object[] args) { throw new NotImplementedException(); }
        public ScriptBlock NewScriptBlock(string scriptText) { throw new NotImplementedException(); }
    }
}
