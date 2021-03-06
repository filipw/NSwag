﻿using NJsonSchema;
using NJsonSchema.CodeGeneration;
using NSwag.CodeGeneration.CodeGenerators.Models;

namespace NSwag.CodeGeneration.CodeGenerators.TypeScript.Templates
{
    internal partial class ProcessResponseTemplate : ITemplate
    {
        public ProcessResponseTemplate(OperationModel model)
        {
            Model = model;
        }

        public OperationModel Model { get; }

        public string Render()
        {
            return ConversionUtilities.TrimWhiteSpaces(TransformText());
        }
    }
}
