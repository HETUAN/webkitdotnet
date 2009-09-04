﻿/*
 * Copyright (c) 2009, Peter Nelson (charn.opcode@gmail.com)
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 * * Redistributions of source code must retain the above copyright notice, 
 *   this list of conditions and the following disclaimer.
 * * Redistributions in binary form must reproduce the above copyright notice, 
 *   this list of conditions and the following disclaimer in the documentation 
 *   and/or other materials provided with the distribution.
 *   
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE 
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
 * POSSIBILITY OF SUCH DAMAGE.
*/

// Various event handlers and argument classes used by WebKitDownload to
// communicate with clients.

using System;
using WebKit.Interop;

namespace WebKit
{
    public delegate void DownloadStartedEvent(object sender, DownloadStartedEventArgs args);
    public delegate void DownloadReceiveDataEvent(object sender, DownloadReceiveDataEventArgs args);
    public delegate void DownloadFinishedEvent(object sender, DownloadFinishedEventArgs args);

    public class DownloadStartedEventArgs : EventArgs
    {
        public string SuggestedFileName { get; private set; }
        public long FileSize { get; private set; }

        public DownloadStartedEventArgs(string SuggestedFileName, long FileSize)
        {
            this.SuggestedFileName = SuggestedFileName;
            this.FileSize = FileSize;
        }
    }

    public class DownloadReceiveDataEventArgs : EventArgs
    {
        public uint Length { get; private set; }

        public DownloadReceiveDataEventArgs(uint Length)
        {
            this.Length = Length;
        }
    }

    public class DownloadFinishedEventArgs : EventArgs
    {
    }
}
