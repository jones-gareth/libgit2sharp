﻿using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    internal enum GitProxyType
    {
        None,
        Auto,
        Specified
    }

    [StructLayout(LayoutKind.Sequential)]
    internal sealed class GitProxyOptions
    {
        public uint Version;
        public GitProxyType Type = GitProxyType.Auto;
        public IntPtr Url;
        public IntPtr CredentialsCb;
        public IntPtr CertificateCheck;
        public IntPtr CbPayload;
    }
}
