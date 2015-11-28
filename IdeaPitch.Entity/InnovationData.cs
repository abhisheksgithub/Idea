namespace IdeaPitch.Entity
{
    #region NameSpace

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion

    /// <summary>
    /// Innovation data model that acts as the core entity in the data manipulation process
    /// </summary>
    public class InnovationData
    {
        public List<string> Title { get; set; }
        public string SelectedTitle { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<string> Occupation { get; set; }
        public string Email { get; set; }
        public string IdeaArea { get; set; }
        public string IdeaSummary { get; set; }
        public IEnumerable<IdeaFragments> IdeaAreaCompact { get; set; }
        public StringBuilder IdeaAreaBuildHtml { get; set; }
    }

    /// <summary>
    /// Child class that is responsible for the dropdown list view
    /// </summary>
    public class IdeaFragments
    {
        public string Headers;
        public string Value;
        public string Text;
    }
}
