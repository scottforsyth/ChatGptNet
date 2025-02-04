﻿using System.Text.Json.Serialization;

namespace ChatGptNet.Models;

/// <summary>
/// Represents a single chat message.
/// </summary>
public class ChatGptMessage
{
    /// <summary>
    /// Gets or sets the role (source) of the messages author.
    /// </summary>
    /// <remarks>
    ///  Valid values are: <em>system</em>, <em>user</em> <em>assistant</em> and <em>function</em>.
    ///  </remarks>
    ///  <seealso cref="ChatGptRoles"/>
    public string Role { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the content of the message.
    /// </summary>
    /// <remarks>
    /// This property is required for all messages except <em>assistant</em> messages with function calls.
    /// </remarks>
    /// <seealso cref="ChatGptRoles"/>
    public string? Content { get; set; }

    /// <summary>
    /// Gets or sets the name of the author of this message.
    /// </summary>
    /// <remarks>
    /// This property is required if role is <em>function</em>, and it should be the name of the function whose response is in the content. May contain a-z, A-Z, 0-9, and underscores, with a maximum length of 64 characters.
    /// </remarks>
    /// <seealso cref="ChatGptRoles"/>"/>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the function call for the message, if any.
    /// </summary>
    [JsonPropertyName("function_call")]
    public ChatGptFunctionCall? FunctionCall { get; set; }
}