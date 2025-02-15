// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Container object for various projection selectors. </summary>
    public partial class SearchIndexerKnowledgeStoreProjection
    {
        /// <summary> Initializes a new instance of SearchIndexerKnowledgeStoreProjection. </summary>
        public SearchIndexerKnowledgeStoreProjection()
        {
            Tables = new ChangeTrackingList<SearchIndexerKnowledgeStoreTableProjectionSelector>();
            Objects = new ChangeTrackingList<SearchIndexerKnowledgeStoreObjectProjectionSelector>();
            Files = new ChangeTrackingList<SearchIndexerKnowledgeStoreFileProjectionSelector>();
        }

        /// <summary> Initializes a new instance of SearchIndexerKnowledgeStoreProjection. </summary>
        /// <param name="tables"> Projections to Azure Table storage. </param>
        /// <param name="objects"> Projections to Azure Blob storage. </param>
        /// <param name="files"> Projections to Azure File storage. </param>
        internal SearchIndexerKnowledgeStoreProjection(IList<SearchIndexerKnowledgeStoreTableProjectionSelector> tables, IList<SearchIndexerKnowledgeStoreObjectProjectionSelector> objects, IList<SearchIndexerKnowledgeStoreFileProjectionSelector> files)
        {
            Tables = tables;
            Objects = objects;
            Files = files;
        }

        /// <summary> Projections to Azure Table storage. </summary>
        public IList<SearchIndexerKnowledgeStoreTableProjectionSelector> Tables { get; }
        /// <summary> Projections to Azure Blob storage. </summary>
        public IList<SearchIndexerKnowledgeStoreObjectProjectionSelector> Objects { get; }
        /// <summary> Projections to Azure File storage. </summary>
        public IList<SearchIndexerKnowledgeStoreFileProjectionSelector> Files { get; }
    }
}
