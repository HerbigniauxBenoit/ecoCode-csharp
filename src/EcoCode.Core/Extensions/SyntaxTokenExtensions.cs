﻿namespace EcoCode.Extensions;

/// <summary>Extensions methods for <see cref="SyntaxToken"/>.</summary>
public static class SyntaxTokenExtensions
{
    private static readonly SyntaxKind[] ModifierOrder =
    [
        SyntaxKind.PublicKeyword, SyntaxKind.PrivateKeyword, SyntaxKind.ProtectedKeyword, SyntaxKind.InternalKeyword,
        SyntaxKind.StaticKeyword,
        SyntaxKind.ExternKeyword,
        SyntaxKind.NewKeyword,
        SyntaxKind.VirtualKeyword, SyntaxKind.AbstractKeyword, SyntaxKind.SealedKeyword, SyntaxKind.OverrideKeyword,
        SyntaxKind.ReadOnlyKeyword,
        SyntaxKind.UnsafeKeyword,
        SyntaxKind.VolatileKeyword,
        SyntaxKind.PartialKeyword,
        SyntaxKind.AsyncKeyword
    ];

    /// <summary>Returns the token modifier order, -1 if the token is not a modifier.</summary>
    /// <param name="token">The token.</param>
    /// <returns>The token modifier order, -1 if not a modifier.</returns>
    public static int GetModifierOrder(this SyntaxToken token) => Array.IndexOf(ModifierOrder, token.Kind());

    /// <summary>Returns whether the token is an accessibility kind.</summary>
    /// <param name="token">The token.</param>
    /// <returns>True if the token is accessibility kind, false otherwise.</returns>
    public static bool IsAccessibilityKind(this SyntaxToken token) =>
        token.IsKind(SyntaxKind.PublicKeyword) ||
        token.IsKind(SyntaxKind.PrivateKeyword) ||
        token.IsKind(SyntaxKind.InternalKeyword) ||
        token.IsKind(SyntaxKind.ProtectedKeyword);
}