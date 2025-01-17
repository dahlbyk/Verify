﻿using System.IO.Compression;

namespace VerifyXunit;

public static partial class Verifier
{
    /// <summary>
    /// Verifies the contents of a <see cref="ZipArchive"/>
    /// </summary>
    public static SettingsTask Verify(
        ZipArchive archive,
        Func<ZipArchiveEntry, bool>? include = null,
        VerifySettings? settings = null,
        object? info = null,
        FileScrubber? fileScrubber = null,
        [CallerFilePath] string sourceFile = "") =>
        Verify(settings, sourceFile, _ => _.VerifyZip(archive, include, info, fileScrubber), true);

    /// <summary>
    /// Verifies the contents of a <see cref="ZipArchive"/>
    /// </summary>
    public static SettingsTask VerifyZip(
        string path,
        Func<ZipArchiveEntry, bool>? include = null,
        VerifySettings? settings = null,
        object? info = null,
        FileScrubber? fileScrubber = null,
        [CallerFilePath] string sourceFile = "") =>
        Verify(settings, sourceFile, _ => _.VerifyZip(path, include, info, fileScrubber), true);

    /// <summary>
    /// Verifies the contents of a <see cref="ZipArchive"/>
    /// </summary>
    public static SettingsTask VerifyZip(
        Stream stream,
        Func<ZipArchiveEntry, bool>? include = null,
        VerifySettings? settings = null,
        object? info = null,
        FileScrubber? fileScrubber = null,
        [CallerFilePath] string sourceFile = "") =>
        Verify(settings, sourceFile, _ => _.VerifyZip(stream, include, info, fileScrubber), true);
}