using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaPitch.Entity;

namespace IdeaPitch.Processing
{
    public class InnovationFormPopulation
    {
        public InnovationFormPopulation(InnovationData userData)
        {
            this.TitleExtract(ref userData);
            this.IdeaAreaCompact(ref userData);
        }
        private void TitleExtract(ref InnovationData userData)
        {
            userData.Title = new List<string> { "Mr", "Master", "Miss", "Mrs", "Miss", "Madam" };
        }
        private void IdeaAreaCompact(ref InnovationData userEntity)
        {
            userEntity.IdeaAreaCompact = new List<IdeaFragments>  { 
                                    new IdeaFragments() { Headers="Health", Text="Creating a world wide network, bringing people together by not having any distinction by race, caste or religion?", Value="Creating a world wide network, bringing people together by not having any distinction by race, caste or religion?" },
                                    new IdeaFragments() { Headers="Health", Text="Tracking down loved one's in a crowded or emergency situation at a cost effective manner?", Value="Tracking down loved one's in a crowded or emergency situation at a cost effective manner?" },
                                    new IdeaFragments() { Headers="Health", Text="Others", Value="Others" },
                                    new IdeaFragments() { Headers="Socail Service", Text="Others", Value="Others" }};
            var headers = (from it in userEntity.IdeaAreaCompact
                           select it.Headers).Distinct().ToList();
            var headersLength = headers.Count;
            int i = 0, k;
            userEntity.IdeaAreaBuildHtml = new StringBuilder();
            while (i < headersLength)
            {
                k = 0;
                foreach (var item in userEntity.IdeaAreaCompact)
                {
                    if (headers[i] == item.Headers && k == 0)
                    {
                        userEntity.IdeaAreaBuildHtml.Append("<optgroup label = " + "\"" + item.Headers + "\"" + ">");
                        k = 1;
                    }
                    if (headers[i] == item.Headers)
                    {
                        userEntity.IdeaAreaBuildHtml.Append("<option value= " + "\"" + item.Value + "\"" + ">" + item.Text + "</option>");
                    }

                }
                if (k == 1)
                    userEntity.IdeaAreaBuildHtml.Append("</optgroup>");
                i++;
            }
        }
    }
}
