using MARSAdvancedTaskPart1.Pages;
using MARSAdvancedTaskPart1.Pages.Components.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAdvancedTaskPart1.Steps
{
    public class ShareSkillSteps
    {
        
        ShareSkillComponent shareSkillComponent;
        public ShareSkillSteps()
        {
           
             shareSkillComponent = new ShareSkillComponent();
        }

        public void ShareSkill(string addTitle, string addDesc, string addCategory, string addSubCategory,
            string addTag, string addServiceType, string addLocationType, string addStartDate, string addEndDate, string addSkillTrade,
            string addSkillExchange,string addAmount, string addActiveStatus)
        {
           
            shareSkillComponent.CreateShareSkill(addTitle,addDesc, addCategory, addSubCategory,
            addTag,addServiceType,addLocationType, addStartDate, addEndDate, addSkillTrade,
            addSkillExchange,addAmount,addActiveStatus);

        }
    }
}
