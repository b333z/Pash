﻿// Copyright (C) Pash Contributors. License: GPL/BSD. See https://github.com/Pash-Project/Pash/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Pash.Implementation;
using System.Management.Automation;
using Pash.ParserIntrinsics;
using Irony.Parsing;
using System.Management.Automation.Language;
using System.Management.Pash.Implementation;

namespace Pash.Implementation
{
    internal class ScriptProcessor : CommandProcessorBase
    {
        readonly ScriptInfo _scriptInfo;


        public ScriptProcessor(ScriptInfo scriptInfo)
            : base(scriptInfo)
        {
            this._scriptInfo = scriptInfo;
        }

        internal override ICommandRuntime CommandRuntime { get; set; }

        internal override void BindArguments(PSObject obj)
        {
            // TODO: bind arguments to "param" statement
        }

        internal override void Initialize()
        {
            // TODO: initialize ScriptProcessor
        }

        internal override void ProcessRecord()
        {
            ExecutionContext context = ExecutionContext.Clone();

            PipelineCommandRuntime pipelineCommandRuntime = (PipelineCommandRuntime)CommandRuntime;

            this._scriptInfo.ScriptBlock.Ast.Visit(new ExecutionVisitor(context, pipelineCommandRuntime, false));
        }

        internal override void Complete()
        {
            // TODO: do a full cleanup
        }

        public override string ToString()
        {
            return this._scriptInfo.ToString();
        }
    }
}
