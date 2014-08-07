using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace jnote
{
   public class JSONDocument
   {
      public JSONDocument()
      {
         FlowDocument = new FlowDocument();
         FlowDocument.Blocks.Add(new Paragraph(new Run("Hello JSON")));
      }

      public FlowDocument FlowDocument { get; set; }
   }
}
