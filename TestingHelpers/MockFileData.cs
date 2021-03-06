﻿using System.Text;

namespace System.IO.Abstractions.TestingHelpers
{
    public class MockFileData
    {
        static readonly Encoding defaultEncoding = Encoding.UTF8;

        byte[] contents;
        DateTimeOffset creationTime = new DateTimeOffset(2010, 01, 02, 00, 00, 00, TimeSpan.FromHours(4));
        DateTimeOffset lastAccessTime = new DateTimeOffset(2010, 02, 04, 00, 00, 00, TimeSpan.FromHours(4));
        DateTimeOffset lastWriteTime = new DateTimeOffset(2010, 01, 04, 00, 00, 00, TimeSpan.FromHours(4));

        public MockFileData(string textContents)
            : this(defaultEncoding.GetBytes(textContents))
        {}

        public MockFileData(byte[] contents)
        {
            this.contents = contents;
        }

        public byte[] Contents
        {
            get { return contents; }
            set { contents = value; }
        }

        public string TextContents
        {
            get { return defaultEncoding.GetString(contents); }
            set { contents = defaultEncoding.GetBytes(value); }
        }

        public DateTimeOffset CreationTime
        {
            get { return creationTime; }
            set { creationTime = value; }
        }

        public DateTimeOffset LastAccessTime
        {
            get { return lastAccessTime; }
            set { lastAccessTime = value; }
        }

        public DateTimeOffset LastWriteTime
        {
            get { return lastWriteTime; }
            set { lastWriteTime = value; }
        }
    }
}