using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Issues
{
    public class IssueList
    {
        public int IssueListId { get; set; }
        public string Nombre { get; set; }
        public int PlanID { get; set; }
        public ICollection<IssueItem> ListaIssues { get; set; }
        public int? EmpresaID { get; set; }

        public void AddIssue(IssueItem issue)
        {
            issue.IssueListId = IssueListId;
            ListaIssues.Add(issue);
        }
        public IssueList(int PlanId)
        {
            IssueListId = 0;
            PlanID = PlanId;
            Nombre = "";
            ListaIssues = new List<IssueItem>();
        }
        public IssueList()
        {
            IssueListId = 0;
            PlanID = 0;
            Nombre = "";
            ListaIssues = new List<IssueItem>();
        }

    }
}
