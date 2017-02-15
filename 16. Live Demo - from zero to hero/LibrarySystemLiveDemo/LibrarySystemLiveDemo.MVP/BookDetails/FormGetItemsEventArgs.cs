using System;

namespace LibrarySystemLiveDemo.MVP.BookDetails
{
    public class FormGetItemsEventArgs : EventArgs
    {
        public Guid? Id { get; private set; }

        public FormGetItemsEventArgs(Guid? id)
        {
            this.Id = id;
        }
    }
}