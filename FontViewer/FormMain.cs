using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace FontViewer {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
         this.ReDrawFonts();
      }

      
      private void ReDrawFonts() {
         FontFamily[] fonts = null;
         if (this.rdoSystem.Checked) {
            fonts = new InstalledFontCollection().Families; 
         } else {
            string dir = this.tbxDir.Text;
            if (Directory.Exists(dir) == false)
               fonts = new FontFamily[0];
            else {
               var files = Directory.GetFiles(dir);
               PrivateFontCollection clt = new PrivateFontCollection();
               foreach (var file in files) {
                  clt.AddFontFile(file);
               }
               fonts = clt.Families;
            }
         }

         string example = this.tbxExample.Text;
         float fontSize = (float)this.numFontSize.Value;
         this.lvwFont.Font = new Font(SystemFonts.DialogFont.FontFamily, fontSize, FontStyle.Regular);
         
         this.lvwFont.Items.Clear();
         this.lvwFont.BeginUpdate();
         foreach(var font in fonts) {
            if (font.Name == string.Empty)
               continue;
            ListViewItem item = new ListViewItem(new string[]{font.Name, example});
            item.UseItemStyleForSubItems = false;
            item.SubItems[0].Font = new Font(SystemFonts.DialogFont.FontFamily, fontSize);
            item.SubItems[1].Font = new Font(font, fontSize);
            this.lvwFont.Items.Add(item);
         }
         
         this.lvwFont.EndUpdate();
      }

      private void rdoSystem_CheckedChanged(object sender, EventArgs e) {
         if (this.rdoSystem.Checked) {
            this.tbxDir.Visible = false;
            this.btnDir.Visible = false;
         } else {
            this.tbxDir.Visible = true;
            this.btnDir.Visible = true;
         }
         this.ReDrawFonts();
      }

      private void numFontSize_ValueChanged(object sender, EventArgs e) {
         this.ReDrawFonts();
      }

      private void tbxExample_TextChanged(object sender, EventArgs e) {
         this.ReDrawFonts();
      }

      private void tbxDir_TextChanged(object sender, EventArgs e) {
         this.ReDrawFonts();
      }

      private void btnDir_Click(object sender, EventArgs e) {
         if (dlgFolder.ShowDialog(this) != DialogResult.OK)
            return;
         this.tbxDir.Text = this.dlgFolder.SelectedPath;
      }

      private void btnHelp_Click(object sender, EventArgs e) {
         var caption = "Font viewer";
         var link = "https://github.com/sim511777/FontViewer";
         var message = link + "\r\nWould you visit?";

         var dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
         if (dr == DialogResult.Yes) {
            System.Diagnostics.Process.Start(link);
         }
      }
   }
}
