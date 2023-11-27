using MARSAdvancedTaskPart1.Pages.Components.HomePageComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.Steps
{
    public class SearchSkillSteps
    {
        SearchSkillComponent searchSkillComponent = new SearchSkillComponent();

        public void SearchSkillByCategory(string category, string subCategory)
        {
            searchSkillComponent.SearchByAllCategory(category,subCategory);
            searchSkillComponent.GoToLastPage();
        }

        public void SearchSkillByFilter(string filter)
        {
            searchSkillComponent.SearchByFilter(filter);
            searchSkillComponent.GoToLastPage();
        }

    }
}
