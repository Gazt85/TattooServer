using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.LinkModels
{
    public class Link
    {
        public string Href { get; private set; }
        public string Rel { get; private set; }
        public string Method { get;private set; }
        public Link()
        { }
        public Link(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }

    }
}
