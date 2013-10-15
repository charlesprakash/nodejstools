﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.NodejsTools {
    class NodejsConstants {
        public const string FileExtension = ".js";
        public const string JavaScript = "JavaScript";
        public const string Nodejs = "Node.js";

        public const string NodeExePath = "NodeExePath";
        public const string NodeExeArguments = "NodeExeArguments";
        public const string ScriptArguments = "ScriptArguments";
        public const string NodejsPort = "NodejsPort";
        public const string StartWebBrowser = "StartWebBrowser";
        public const string LaunchUrl = "LaunchUrl";
        public const string ProjectFileFilter = "Node.js Project File (*.njsproj)\n*.njsproj\nAll Files (*.*)\n*.*\n";

        public const string NodeModulesFolder = "node_modules";
        public const string PackageJsonFile = "package.json";
        public const string PackageJsonMainFileKey = "main";
        public const string DefaultPackageMainFile = "index.js";

        public const string BaseRegistryKey = "NodejsTools";

        [Export, Name(Nodejs), BaseDefinition(JavaScript)]
        internal static ContentTypeDefinition ContentTypeDefinition = null;
    }
}