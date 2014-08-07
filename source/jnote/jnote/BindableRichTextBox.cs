using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace jnote
{
   public class BindableRichTextBox : DependencyObject
   {
      public static readonly DependencyProperty DocumentProperty =
        DependencyProperty.RegisterAttached(
        "Document",
        typeof(FlowDocument),
        typeof(BindableRichTextBox),
        new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnDocumentChanged)));

      public static FlowDocument GetDocument(DependencyObject obj)
      {
         return (FlowDocument)obj.GetValue(DocumentProperty);
      }

      public static void SetDocument(DependencyObject obj, FlowDocument value)
      {
         obj.SetValue(DocumentProperty, value);
      }

      public static void OnDocumentChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
      {
         var rtb = (RichTextBox)obj;
         var doc = (FlowDocument)args.NewValue;
         rtb.Document = doc;
      }
   }
}
