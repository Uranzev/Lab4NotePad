using NotePad.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        String path;
        String openingText;
        public Form1()
        {
            InitializeComponent();
        }
        private void openLast()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Documents|*.txt|Text Documents|*.zev";
            ofd.InitialDirectory = Settings.Default.lastPath;
            ofd.ValidateNames = true;
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader srm = new StreamReader(ofd.FileName))
                {
                    path = ofd.FileName;
                    Task<String> text = srm.ReadToEndAsync();
                    textBox.Text = text.Result;
                    openingText = text.Result;
                }
            }
        }
        private void нээхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLast();
            
        }

        private void хадгалахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfl = new SaveFileDialog();
            sfl.Filter = "Text Documents|*.txt|Text Documents|*.zev";
                   
            DialogResult dialogResult = sfl.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                saveFile(sfl.FileName);
            }

        }

        private void гарахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openingText) && openingText != textBox.Text) showWarningDialog();
            else this.Close();
        }

        private void saveFile(String fileName)
        {
            FileStream fParameter = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(textBox.Text);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
            path = fileName;
           
        }

        private void showWarningDialog()
        {
            Form dialog = new Form();
            dialog.Width = 300;
            dialog.Height = 160;
            dialog.Text = "Анхааруулга";
            Label textLabel = new Label() 
            { 
                Left = 50, 
                Top = 20, 
                Text = " Өөрчлөлтийг хадгалах уу?.",
                Width = 200,
                
            };
            Button confirmation = new Button() 
            {
                Text = "Тийм", 
                Left = 20,
                Width = 100, 
                Top = 70 
            };
            confirmation.Click += (sender, e) => {
                saveFile(path);
                dialog.Close(); 
            };
            Button decline = new Button()
            {
                Text = "Үгүй",
                Width = 100,
                Left = 140,
                Top = 70,

            };
            decline.Click += (sender, e) => { dialog.Close(); };
            dialog.Controls.Add(confirmation);
            dialog.Controls.Add(textLabel);
            dialog.Controls.Add(decline);
            dialog.ShowDialog();
        }
     

     

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
           
            if (!string.IsNullOrEmpty(openingText) && openingText != textBox.Text) showWarningDialog();
            else base.OnFormClosing(e);


        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Settings.Default.lastPath = path;
            Settings.Default.Save();
            base.OnFormClosed(e);
        }

    }

    
       
        
        

}
