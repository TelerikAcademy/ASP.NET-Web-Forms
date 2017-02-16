using System;

namespace LibrarySystemLiveDemo.MVP.Search
{
    public class SearchEventArgs : EventArgs
    {
        public string QueryParams { get; private set; }

        public SearchEventArgs(string queryParams)
        {
            this.QueryParams = queryParams;
        }
    }
}