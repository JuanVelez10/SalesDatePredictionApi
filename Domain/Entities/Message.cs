using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Message
    {
        public int Code { get; set; }
        public int MessageType { get; set; }
        public string Message1 { get; set; } = null!;
    }
}
