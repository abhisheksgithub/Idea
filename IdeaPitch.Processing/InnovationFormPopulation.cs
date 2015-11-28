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
                                    new IdeaFragments() { Headers="", Text="", Value="" },
                                    new IdeaFragments() { Headers="", Text="", Value="" }};
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

                userEntity.IdeaAreaBuildHtml.Append("</optgroup>");
                i++;
            }


            //UserData.Occupation = new List<string> { "Student", "Working Professional", "Free Lancers", "Out of the box thinkers" };
            //UserData.InnovateSection = new List<DropDownList>{new DropDownList { label = "Health", value = "Creating a world wide network, bringing people together by not having any distinction by race, caste or religion?" },
            //    new DropDownList { label = "Health", value = "Tracking down loved one's in a crowded or emergency situation at a cost effective manner?" },
            //    new DropDownList { label = "Social Service", value = "Others" }};
            //var headers = (from it in UserData.InnovateSection
            //               select it.label).Distinct().ToList();
            //var headersLength = headers.Count;
            //int i = 0, k;
            //UserData.Innovate = new System.Text.StringBuilder();
            //while (i < headersLength)
            //{
            //    k = 0;
            //    foreach (var item in UserData.InnovateSection)
            //    {
            //        if (headers[i] == item.label && k == 0)
            //        {
            //            UserData.Innovate.Append("<optgroup label = " + "\"" + item.label + "\"" + ">");
            //            k = 1;
            //        }
            //        if (headers[i] == item.label)
            //        {
            //            UserData.Innovate.Append("<option value= " + "\"" + item.value + "\"" + ">" + item.value + "</option>");
            //        }

            //    }

            //    UserData.Innovate.Append("</optgroup>");
            //    i++;
            //}
            //return View(UserData);

        }
    }
}
