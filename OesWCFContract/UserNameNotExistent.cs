using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace OesWCFContract
{
    [DataContract]
    public class UserNameNotExistent
    {
        [DataMember]
        public string Messge { get; set; }
    }
}
