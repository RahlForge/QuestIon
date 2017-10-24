using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestIon.DataClasses
{
    public class QuestionnaireEntry
    {
        protected Type dataType;
        protected int sortOrder;        

        public int Id { get; protected set; }
        public string Text { get; protected set; }
        public string Response { get; set; }
        public bool Required { get; protected set; }

        public QuestionnaireEntry()
        {

        }
    }
}
