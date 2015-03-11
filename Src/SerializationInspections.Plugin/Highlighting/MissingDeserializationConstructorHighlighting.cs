﻿using JetBrains.Annotations;
using SerializationInspections.Plugin.Highlighting;
using JetBrains.ReSharper.Psi.Tree;
#if RESHARPER8
using JetBrains.ReSharper.Daemon;

#else
using JetBrains.ReSharper.Feature.Services.Daemon;
#endif

[assembly: RegisterConfigurableSeverity(
    MissingDeserializationConstructorHighlighting.SeverityId,
    null,
    HighlightingGroupIds.CodeSmell,
    MissingDeserializationConstructorHighlighting.Title,
    MissingDeserializationConstructorHighlighting.Description,
    Severity.WARNING,
    solutionAnalysisRequired: false)]

namespace SerializationInspections.Plugin.Highlighting
{
    /// <summary>
    /// A highlighting for missing deserialization constructors.
    /// </summary>
    [ConfigurableSeverityHighlighting(
        SeverityId,
        "CSHARP",
        OverlapResolve = OverlapResolveKind.WARNING,
        ToolTipFormatString = Message)]
    public class MissingDeserializationConstructorHighlighting : SerializationHighlightingBase
    {
        public const string SeverityId = "MissingDeserializationConstructor";

        private const string Message = "Missing deserialization constructor";

        public const string Title = "Missing deserialization constructor";

        public const string Description = Title;

        public MissingDeserializationConstructorHighlighting([NotNull] ITypeDeclaration typeDeclaration)
            : base(typeDeclaration, Message)
        {
        }
    }
}