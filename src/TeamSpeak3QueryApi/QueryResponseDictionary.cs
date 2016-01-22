using System;
using System.Collections.Generic;

#if FW
using System.Runtime.Serialization;
#endif

namespace TeamSpeak3QueryApi.Net
{
    /// <summary>Represents the data of a query response.</summary>
#if FW
    [Serializable]
#endif
    public class QueryResponseDictionary : Dictionary<string, object>
    {
        /// <summary>Creates a new instance of <see cref="QueryResponseDictionary"/>.</summary>
        public QueryResponseDictionary()
        { }

#if FW
        /// <summary>Initializes a new instance of the <see cref="QueryResponseDictionary"/> with serialized data.</summary>
        protected QueryResponseDictionary(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
#endif
    }
}
