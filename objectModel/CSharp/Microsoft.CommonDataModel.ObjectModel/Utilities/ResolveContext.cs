// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.CommonDataModel.ObjectModel.Utilities
{
    using Microsoft.CommonDataModel.ObjectModel.Cdm;
    using Microsoft.CommonDataModel.ObjectModel.Enums;
    using Microsoft.CommonDataModel.ObjectModel.Utilities.Logging;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public class ResolveContext : CdmCorpusContext
    {
        internal Stack<ResolveContextScope> ScopeStack;
        internal ResolveContextScope CurrentScope;
        public CdmStatusLevel ReportAtLevel { get; set; }
        public CdmCorpusDefinition Corpus { get; set; }
        public EventCallback StatusEvent { get; set; }
        ///<inheritdoc/>
        public EventList Events { get; }
        ///<inheritdoc/>
        public string CorrelationId { get; set; }
        public HashSet<CdmLogCode> SuppressedLogCodes { get; }

        internal string RelativePath;
        internal IDictionary<string, dynamic> Cache;

        public ResolveContext(CdmCorpusDefinition corpus, EventCallback statusEvent, CdmStatusLevel? reportAtLevel = null)
        {
            this.ReportAtLevel = reportAtLevel != null ? reportAtLevel.Value : CdmStatusLevel.Warning;
            this.StatusEvent = statusEvent;
            this.Cache = new ConcurrentDictionary<string, object>();
            this.Corpus = corpus;
            this.Events = new EventList();
            this.SuppressedLogCodes = new HashSet<CdmLogCode>();
        }

        internal void PushScope(CdmTraitDefinition currentTrait)
        {
            if (this.ScopeStack == null)
                this.ScopeStack = new Stack<ResolveContextScope>();

            ResolveContextScope ctxNew = new ResolveContextScope
            {
                CurrentTrait = currentTrait != null ? currentTrait : this.CurrentScope?.CurrentTrait,
                CurrentParameter = 0
            };

            this.CurrentScope = ctxNew;
            this.ScopeStack.Push(ctxNew);
        }

        internal void PopScope()
        {
            this.ScopeStack.Pop();
            this.CurrentScope = this.ScopeStack.Count > 0 ? this.ScopeStack.Peek() : null;
        }

        internal dynamic FetchCache(CdmObjectBase forObj, ResolveOptions resOpt, string kind)
        {
            string key = forObj.Id.ToString() + "_" + (resOpt?.WrtDoc != null ? resOpt.WrtDoc.Id.ToString() : "NULL") + "_" + kind;
            if (this.Cache.ContainsKey(key))
            {
                return this.Cache[key];
            }
            return null;
        }

        internal void UpdateCache(CdmObjectBase forObj, ResolveOptions resOpt, string kind, dynamic value)
        {
            string key = forObj.Id.ToString() + "_" + (resOpt?.WrtDoc != null ? resOpt.WrtDoc.Id.ToString() : "NULL") + "_" + kind;
            if (!this.Cache.ContainsKey(key))
            {
                this.Cache.Add(key, value);
            }
            else
            {
                this.Cache[key] = value;
            }
        }
    }
}
