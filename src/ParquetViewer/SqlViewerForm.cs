using System.Windows.Forms;

namespace ParquetViewer;
public partial class SqlViewerForm : Form
{
    public SqlViewerForm()
    {
        InitializeComponent();
    }

    public void SetText(string text)
    {
        textBox1.Text = text;
    }

    private void buttonCopy_Click(object sender, System.EventArgs e)
    {
        Clipboard.SetText(textBox1.Text);
        MessageBox.Show(this, "Create table script copied to clipboard!", "Parquet Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void buttonClose_Click(object sender, System.EventArgs e)
    {
        Close();
    }
}
