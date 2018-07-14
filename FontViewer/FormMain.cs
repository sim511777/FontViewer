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

namespace FontViewer {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
         this.ReDrawFonts();
      }

      FontFamily[] fonts = new InstalledFontCollection().Families;
      
      private void ReDrawFonts() {

         string example = this.tbxExample.Text;
         float fontSize = (float)this.numFontSize.Value;
         this.lvwFont.Font = new Font(SystemFonts.DefaultFont.FontFamily, fontSize*1.2f, FontStyle.Regular);
         
         this.lvwFont.Items.Clear();
         this.lvwFont.BeginUpdate();
         foreach(var font in this.fonts) {
            if (font.Name == string.Empty)
               continue;
            ListViewItem item = new ListViewItem(new string[]{font.Name, example});
            item.Font = new Font(font, fontSize);
            this.lvwFont.Items.Add(item);
         }
         
         this.lvwFont.EndUpdate();
      }

      private void numFontSize_ValueChanged(object sender, EventArgs e) {
         this.ReDrawFonts();
      }

      private void tbxExample_TextChanged(object sender, EventArgs e) {
         this.ReDrawFonts();
      }
   }
}
