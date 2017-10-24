using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestIon.DataClasses
{
    public class Questionnaire
    {        
        protected List<QuestionnaireEntry> questionnaire;

        public int Id { get; protected set; }

        public Questionnaire()
        {

        }
    }
}
