// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.Cci
{
    /// <summary>
    /// Represents an assembly reference with an alias (i.e. an extern alias in C#).
    /// </summary>
    internal struct ExternNamespace
    {
        private readonly string _namespaceAlias;
        private readonly string _assemblyName;

        internal ExternNamespace(string namespaceAlias, string assemblyName)
        {
            _namespaceAlias = namespaceAlias;
            _assemblyName = assemblyName;
        }

        /// <summary>
        /// An alias for the global namespace of the assembly.
        /// </summary>
        public string NamespaceAlias { get { return _namespaceAlias; } }

        /// <summary>
        /// The name of the referenced assembly.
        /// </summary>
        public string AssemblyName { get { return _assemblyName; } }
    }
}
