using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContentListExtractor
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SrcPath.TextChanged += (object sender, TextChangedEventArgs e) =>
            {
                StartButton.IsEnabled = System.IO.File.Exists(SrcPath.Text);
            };
        }

        private void SrcButton_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            fileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(SrcPath.Text);
            var result = fileDialog.ShowDialog();
            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    var file = fileDialog.FileName;
                    SrcPath.Text = file;
                    SrcPath.ToolTip = file;
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    break;
            }
        }

        private void DstButton_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.SaveFileDialog();
            fileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(DstPath.Text);
            fileDialog.FileName = System.IO.Path.GetFileName(DstPath.Text);
            var result = fileDialog.ShowDialog();
            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    var file = fileDialog.FileName;
                    DstPath.Text = file;
                    DstPath.ToolTip = file;
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    break;
            }
        }


        private System.IO.TextWriter writer;
        private string val = null;

        private void enumsub(DocumentFormat.OpenXml.OpenXmlElement root)
        {
            foreach (var item in root.ChildElements)
            {
                if (item.LocalName == "p")
                {
                    val = null;
                    enumsub(item);
                    if (val == "2") writer.WriteLine(item.InnerText);
                    continue;
                }
                else if (item.LocalName == "pStyle")
                {
                    val = item.GetAttribute("val", "http://schemas.openxmlformats.org/wordprocessingml/2006/main").Value;
                }
                //writer.WriteLine(item.OuterXml);
                enumsub(item);
            }
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var path = DstPath.Text;
            var spath = SrcPath.Text;
            await Task.Run(async () =>
            {
                await this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        () =>
                        {
                            MyProgressBar.Visibility = Visibility.Visible;
                        })
                    );
                try
                {
                    using (var outputWriter = System.IO.File.CreateText(path))
                    {
                        writer = outputWriter;
                        await Task.Delay(1000);
                        using (WordprocessingDocument wordDocument =
    WordprocessingDocument.Open(spath, false))
                        {
                            // Assign a reference to the existing document body.
                            DocumentFormat.OpenXml.Wordprocessing.Body body = wordDocument.MainDocumentPart.Document.Body;
                            enumsub(body);
                        }
                        outputWriter.WriteLine($"# created {DateTimeOffset.Now}");
                        writer = null;
                    }
                }
                finally
                {
                    await this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        () =>
                        {
                            MyProgressBar.Visibility = Visibility.Hidden;
                        })
                    );
                }
            });
            System.Diagnostics.Process.Start(DstPath.Text);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
