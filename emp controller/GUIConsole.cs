using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;

namespace emp_controller
{
    public class GUIConsole : TextWriter
    {
        // The control where we will write text.
        private RichTextBox _control;
        public GUIConsole(RichTextBox control)
        {
            _control = control;
        }

        public override void Write(char value)
        {
            _control.Document.Blocks.Add(new Paragraph(new Run(value.ToString())));
        }

        public override void Write(string value)
        {
            _control.Document.Blocks.Add(new Paragraph(new Run(value)));

        }

        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }
        }
    }
}