﻿namespace VerifyMSTest;

public partial class VerifyBase
{
    /// <summary>
    /// Verifies the contents of <paramref name="path"/>.
    /// </summary>
    public SettingsTask VerifyFile(
        string path,
        VerifySettings? settings = null,
        object? info = null,
        [CallerFilePath] string sourceFile = "") =>
        Verify(settings, sourceFile, _ => _.VerifyFile(path, info));

    /// <summary>
    /// Verifies the contents of <paramref name="path"/>.
    /// Differs from passing <see cref="FileInfo"/> to <code>Verify(object? target)</code> which will verify the full path.
    /// </summary>
    public SettingsTask VerifyFile(
        FileInfo path,
        VerifySettings? settings = null,
        object? info = null,
        [CallerFilePath] string sourceFile = "") =>
        Verify(settings, sourceFile, _ => _.VerifyFile(path, info));
}