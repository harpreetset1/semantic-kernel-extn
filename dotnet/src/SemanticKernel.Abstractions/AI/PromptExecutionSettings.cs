﻿// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.TextGeneration;

namespace Microsoft.SemanticKernel;

/// <summary>
/// Execution settings for an AI request.
/// Implementors of <see cref="ITextGenerationService"/> or <see cref="IChatCompletionService"/> can extend this
/// if the service they are calling supports additional properties. For an example please reference
/// the Microsoft.SemanticKernel.Connectors.OpenAI.OpenAIPromptExecutionSettings implementation.
/// </summary>
public class PromptExecutionSettings
{
    /// <summary>
    /// Default service identifier.
    /// </summary>
    public const string DefaultServiceId = "default";

    /// <summary>
    /// Model identifier.
    /// This identifies the AI model these settings are configured for e.g., gpt-4, gpt-3.5-turbo
    /// </summary>
    [JsonPropertyName("model_id")]
    public string? ModelId { get; set; }

    /// <summary>
    /// Extra properties that may be included in the serialized execution settings.
    /// </summary>
    /// <remarks>
    /// Avoid using this property if possible. Instead, use one of the classes that extends <see cref="PromptExecutionSettings"/>.
    /// </remarks>
    [JsonExtensionData]
    public Dictionary<string, object>? ExtensionData { get; set; }
}
